namespace ScreenPixelMonitor
{
    partial class Alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new Button();
            lblMessage = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(324, 165);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(147, 32);
            btnOK.TabIndex = 0;
            btnOK.Text = "Continue Monitoring";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(255, 255, 192);
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(10, 10);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(439, 67);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Pixels on the screen have changed";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(lblMessage);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(459, 87);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 128);
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(459, 54);
            panel2.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 255, 192);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(439, 34);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ALERT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(12, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 32);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Stop Monitoring";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 200);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Alert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alert";
            Load += Alert_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lblMessage;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Button btnCancel;
    }
}