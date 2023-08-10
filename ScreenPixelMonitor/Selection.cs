namespace ScreenPixelMonitor
{
    public partial class Selection : Form
    {
        private bool IsMouseDown { get; set; } = false;

        private SolidBrush myBrush { get; set; } = new SolidBrush(Color.Red);
        private Graphics? formGraphics { get; set; } = null;
        private Point? StartLocation { get; set; } = null;

        public Rectangle? SelectedRegion { get; set; } = null;

        public Selection()
        {
            InitializeComponent();

            Cursor = Cursors.Cross;
        }

        private void Selection_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            StartLocation = e.Location;
            formGraphics = this.CreateGraphics();
        }

        private void Selection_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;

            formGraphics!.Dispose();
            formGraphics = null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Selection_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsMouseDown)
                return;

            formGraphics!.Clear(this.BackColor);

            var x1 = StartLocation!.Value.X;
            var y1 = StartLocation!.Value.Y;

            var x2 = e.Location.X;
            var y2 = e.Location.Y;

            var x = Math.Min(x1, x2);
            var y = Math.Min(y1, y2);

            var width = Math.Abs(e.Location.X - StartLocation!.Value.X);
            var height = Math.Abs(e.Location.Y - StartLocation!.Value.Y);

            SelectedRegion = new Rectangle(x, y, width, height);

            formGraphics.FillRectangle(myBrush, SelectedRegion.Value);
        }

        private void Selection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
