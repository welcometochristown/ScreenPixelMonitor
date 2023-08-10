using System.Drawing.Imaging;
using System.Media;
using System.Windows.Forms;

namespace ScreenPixelMonitor
{
    public partial class MainForm : Form
    {
        private Rectangle? SelectedRegion { get; set; } = null;
        private Bitmap? RegionCapture { get; set; } = null;
        private bool IsMonitoring { get; set; }
        public MainForm()
        {
            InitializeComponent();

            txtAudioPath.Text = Properties.Settings.Default.AudioPath;
        }

        private void btnRegionSelect_Click(object sender, EventArgs e)
        {
            this.Hide();

            var selection = new Selection();

            SelectedRegion = null;
            RegionCapture?.Dispose();
            RegionCapture = null;
            pictureBox1.Image = null;

            if (selection.ShowDialog() == DialogResult.OK) { 
                SelectedRegion = selection.SelectedRegion!.Value;
                CaptureRegion();
            }

            selection.Dispose();

            this.Show();
        }

        private void CaptureRegion()
        {
            if(SelectedRegion != null)
            {
                using (var screen = CaptureMyScreen())
                {
                    RegionCapture?.Dispose();
                    RegionCapture = GetRegion(screen, SelectedRegion.Value);
                }
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = RegionCapture;
        }

        private Bitmap CaptureMyScreen()
        {
            Bitmap captureBitmap = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            using (Graphics captureGraphics = Graphics.FromImage(captureBitmap))
            {
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            }

            return captureBitmap;
        }


        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (btnMonitor.Text == "Stop")
                StopMonitoring();
            else
                StartMonitoring();
        }

        public delegate void UpdateButtons(bool btnRegionSelectEnabled, string btnMonitorText);

        private void StartMonitoring()
        {
            if (SelectedRegion == null || RegionCapture == null)
                return;

            btnRegionSelect.Enabled = false;
            btnMonitor.Text = "Stop";
            IsMonitoring = true;

            var form = this;

            Task.Run(() =>
            {
                while (IsMonitoring)
                {
                    using (var screen = CaptureMyScreen())
                    {
                        var region = GetRegion(screen, SelectedRegion.Value);

                        if (!CompareBitmaps(region, RegionCapture))
                        {
                            //alert!
                            if (!string.IsNullOrEmpty(txtAudioPath.Text))
                            {
                                using (var soundPlayer = new SoundPlayer(txtAudioPath.Text))
                                {
                                    soundPlayer.Play();
                                }
                            }

                            var alert = new Alert { FlashAlert = true };

                            if (alert.ShowDialog(txtMessage.Text) == DialogResult.Cancel)
                            {
                                region.Dispose();
                                break;
                            }
                            else
                            {
                                RegionCapture?.Dispose();
                                using(var currentScreen = CaptureMyScreen())
                                {
                                    RegionCapture = GetRegion(currentScreen, SelectedRegion.Value);
                                }

                                form.Invoke(new Action(() =>
                                {
                                    pictureBox1.Image = RegionCapture;
                                }));
                            }
                        }
                        else
                        {
                            region.Dispose();
                        }
                    }


                    Thread.Sleep(500);
                }

                form.Invoke(new UpdateButtons((bool b, string s) =>
                {
                    btnRegionSelect.Enabled = b;
                    btnMonitor.Text = s;
                }), true, "Monitor");
            });
        }

        private void StopMonitoring()
        {
            IsMonitoring = false;
        }

        private Bitmap GetRegion(Bitmap b, Rectangle r)
        {
            var nb = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(nb))
            {
                g.DrawImage(b, -r.X, -r.Y);
                return nb;
            }
        }

        private bool CompareBitmaps(Bitmap b1, Bitmap b2)
        {
            int width = b1.Width;
            int height = b1.Height;

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (b1.GetPixel(x, y) != b2.GetPixel(x, y))
                        return false;

            return true;
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAudioPath.Text = ofd.FileName;
            }
        }

        private void txtAudioPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AudioPath = txtAudioPath.Text;
            Properties.Settings.Default.Save();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Message = txtMessage.Text;
            Properties.Settings.Default.Save();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CaptureRegion();
        }
    }
}