using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
namespace ScreenPixelMonitor
{
    public partial class Alert : Form
    {
        public bool FlashAlert { get; set; }

        public Alert()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialog(string message, string title = "ALERT")
        {
            lblMessage.Text = message;
            lblTitle.Text = title;

            return base.ShowDialog();
        }

        public delegate void ChangeBackgroundColor(Color color);

        private void Alert_Load(object sender, EventArgs e)
        {
            var form = this;
            var originalBackgroundColor = form.BackColor;

            if (FlashAlert)
            {
                Task.Run(() =>
                {
                    while (Visible)
                    {
                        try
                        {
                            form.Invoke(new ChangeBackgroundColor((Color c) =>
                            {
                                form.BackColor = c;
                            }), Color.Yellow);

                            Thread.Sleep(500);

                            form.Invoke(new ChangeBackgroundColor((Color c) =>
                            {
                                form.BackColor = c;
                            }), originalBackgroundColor);

                            Thread.Sleep(500);

                        }
                        catch (Exception)
                        {
                            /*ignore, probably closing or shutting down*/
                        }

                    }
                });
            }
        }
    }
}
