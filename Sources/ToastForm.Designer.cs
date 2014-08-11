namespace spotifytoaster
{
    partial class ToastForm
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
            this.albumArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // albumArt
            // 
            this.albumArt.InitialImage = null;
            this.albumArt.Location = new System.Drawing.Point(10, 10);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(64, 64);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumArt.TabIndex = 3;
            this.albumArt.TabStop = false;
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(363, 84);
            this.Controls.Add(this.albumArt);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "ToastForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnExit);
            this.VisibleChanged += new System.EventHandler(this.toastVisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox albumArt;
    }
}