namespace ScreenPixelMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegionSelect = new Button();
            btnMonitor = new Button();
            pictureBox1 = new PictureBox();
            grpButtons = new GroupBox();
            txtAudioPath = new TextBox();
            btnAudio = new Button();
            label1 = new Label();
            txtMessage = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegionSelect
            // 
            btnRegionSelect.Location = new Point(6, 12);
            btnRegionSelect.Name = "btnRegionSelect";
            btnRegionSelect.Size = new Size(117, 41);
            btnRegionSelect.TabIndex = 0;
            btnRegionSelect.Text = "Select Region";
            btnRegionSelect.UseVisualStyleBackColor = true;
            btnRegionSelect.Click += btnRegionSelect_Click;
            // 
            // btnMonitor
            // 
            btnMonitor.Location = new Point(438, 12);
            btnMonitor.Name = "btnMonitor";
            btnMonitor.Size = new Size(115, 41);
            btnMonitor.TabIndex = 1;
            btnMonitor.Text = "Monitor";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += btnMonitor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(11, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // grpButtons
            // 
            grpButtons.Controls.Add(btnRegionSelect);
            grpButtons.Controls.Add(btnMonitor);
            grpButtons.Location = new Point(11, 284);
            grpButtons.Name = "grpButtons";
            grpButtons.Size = new Size(559, 61);
            grpButtons.TabIndex = 3;
            grpButtons.TabStop = false;
            // 
            // txtAudioPath
            // 
            txtAudioPath.Location = new Point(70, 12);
            txtAudioPath.Name = "txtAudioPath";
            txtAudioPath.ReadOnly = true;
            txtAudioPath.Size = new Size(455, 23);
            txtAudioPath.TabIndex = 4;
            txtAudioPath.TextChanged += txtAudioPath_TextChanged;
            // 
            // btnAudio
            // 
            btnAudio.Location = new Point(531, 12);
            btnAudio.Name = "btnAudio";
            btnAudio.Size = new Size(39, 23);
            btnAudio.TabIndex = 5;
            btnAudio.Text = "...";
            btnAudio.UseVisualStyleBackColor = true;
            btnAudio.Click += btnAudio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Audio";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(70, 44);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(500, 23);
            txtMessage.TabIndex = 7;
            txtMessage.Text = "Pixels have changed!";
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 47);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 357);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAudio);
            Controls.Add(txtAudioPath);
            Controls.Add(grpButtons);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Screen Pixel Monitor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegionSelect;
        private Button btnMonitor;
        private PictureBox pictureBox1;
        private GroupBox grpButtons;
        private TextBox txtAudioPath;
        private Button btnAudio;
        private Label label1;
        private TextBox txtMessage;
        private Label label2;
    }
}