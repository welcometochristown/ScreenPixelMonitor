﻿namespace ScreenPixelMonitor
{
    partial class Selection
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
            SuspendLayout();
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Selection";
            Opacity = 0.5D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selection";
            WindowState = FormWindowState.Maximized;
            KeyDown += Selection_KeyDown;
            MouseDown += Selection_MouseDown;
            MouseMove += Selection_MouseMove;
            MouseUp += Selection_MouseUp;
            ResumeLayout(false);
        }

        #endregion
    }
}