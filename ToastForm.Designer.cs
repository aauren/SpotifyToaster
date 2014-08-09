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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.trackBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.Black;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Enabled = false;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.titleBox.Location = new System.Drawing.Point(13, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(338, 16);
            this.titleBox.TabIndex = 0;
            this.titleBox.Text = "Spotify Song Changed";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // artistBox
            // 
            this.artistBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.artistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistBox.Enabled = false;
            this.artistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistBox.ForeColor = System.Drawing.Color.White;
            this.artistBox.Location = new System.Drawing.Point(113, 48);
            this.artistBox.Name = "artistBox";
            this.artistBox.ReadOnly = true;
            this.artistBox.Size = new System.Drawing.Size(238, 15);
            this.artistBox.TabIndex = 1;
            this.artistBox.Text = "Artist";
            // 
            // trackBox
            // 
            this.trackBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.trackBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackBox.Enabled = false;
            this.trackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBox.ForeColor = System.Drawing.Color.White;
            this.trackBox.Location = new System.Drawing.Point(113, 77);
            this.trackBox.Name = "trackBox";
            this.trackBox.ReadOnly = true;
            this.trackBox.Size = new System.Drawing.Size(238, 15);
            this.trackBox.TabIndex = 2;
            this.trackBox.Text = "Track Name";
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(363, 109);
            this.Controls.Add(this.trackBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.titleBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "ToastForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToastForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.ToastForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.TextBox trackBox;
    }
}