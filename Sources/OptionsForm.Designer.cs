namespace spotifytoaster.Sources
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.toasterNotificationPopupSpeed = new System.Windows.Forms.TextBox();
            this.toasterNotificationPopupSpeedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toasterForegroundColorLabel = new System.Windows.Forms.Label();
            this.toasterBackgroundColorLabel = new System.Windows.Forms.Label();
            this.toasterNotificationDuration = new System.Windows.Forms.TextBox();
            this.toasterNotificationDurationLabel = new System.Windows.Forms.Label();
            this.toasterAlphaLevel = new System.Windows.Forms.TextBox();
            this.toasterAlphaLevelLabel = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.foregroundColor = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toasterNotificationPopupSpeed
            // 
            this.toasterNotificationPopupSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toasterNotificationPopupSpeed.Location = new System.Drawing.Point(230, 5);
            this.toasterNotificationPopupSpeed.Name = "toasterNotificationPopupSpeed";
            this.toasterNotificationPopupSpeed.Size = new System.Drawing.Size(101, 20);
            this.toasterNotificationPopupSpeed.TabIndex = 0;
            this.toasterNotificationPopupSpeed.Enter += new System.EventHandler(this.toasterPopupSpeedToolTip);
            this.toasterNotificationPopupSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.toasterPopupSpeedValidation);
            // 
            // toasterNotificationPopupSpeedLabel
            // 
            this.toasterNotificationPopupSpeedLabel.Location = new System.Drawing.Point(3, 0);
            this.toasterNotificationPopupSpeedLabel.Name = "toasterNotificationPopupSpeedLabel";
            this.toasterNotificationPopupSpeedLabel.Size = new System.Drawing.Size(221, 30);
            this.toasterNotificationPopupSpeedLabel.TabIndex = 1;
            this.toasterNotificationPopupSpeedLabel.Text = "Toaster Notification Popup Speed:";
            this.toasterNotificationPopupSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31746F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68254F));
            this.tableLayoutPanel1.Controls.Add(this.toasterForegroundColorLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.toasterBackgroundColorLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.toasterNotificationDuration, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toasterNotificationDurationLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toasterNotificationPopupSpeedLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toasterNotificationPopupSpeed, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toasterAlphaLevel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toasterAlphaLevelLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.backgroundColor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.foregroundColor, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 149);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toasterForegroundColorLabel
            // 
            this.toasterForegroundColorLabel.Location = new System.Drawing.Point(3, 120);
            this.toasterForegroundColorLabel.Name = "toasterForegroundColorLabel";
            this.toasterForegroundColorLabel.Size = new System.Drawing.Size(221, 30);
            this.toasterForegroundColorLabel.TabIndex = 10;
            this.toasterForegroundColorLabel.Text = "Toaster Foreground Color:";
            this.toasterForegroundColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toasterBackgroundColorLabel
            // 
            this.toasterBackgroundColorLabel.Location = new System.Drawing.Point(3, 90);
            this.toasterBackgroundColorLabel.Name = "toasterBackgroundColorLabel";
            this.toasterBackgroundColorLabel.Size = new System.Drawing.Size(221, 30);
            this.toasterBackgroundColorLabel.TabIndex = 7;
            this.toasterBackgroundColorLabel.Text = "Toaster Background Color:";
            this.toasterBackgroundColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toasterNotificationDuration
            // 
            this.toasterNotificationDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toasterNotificationDuration.Location = new System.Drawing.Point(230, 35);
            this.toasterNotificationDuration.Name = "toasterNotificationDuration";
            this.toasterNotificationDuration.Size = new System.Drawing.Size(101, 20);
            this.toasterNotificationDuration.TabIndex = 1;
            this.toasterNotificationDuration.Enter += new System.EventHandler(this.toasterDurationToolTip);
            this.toasterNotificationDuration.Validating += new System.ComponentModel.CancelEventHandler(this.toasterDurationValidation);
            // 
            // toasterNotificationDurationLabel
            // 
            this.toasterNotificationDurationLabel.Location = new System.Drawing.Point(3, 30);
            this.toasterNotificationDurationLabel.Name = "toasterNotificationDurationLabel";
            this.toasterNotificationDurationLabel.Size = new System.Drawing.Size(221, 30);
            this.toasterNotificationDurationLabel.TabIndex = 2;
            this.toasterNotificationDurationLabel.Text = "Toaster Notification Duration:";
            this.toasterNotificationDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toasterAlphaLevel
            // 
            this.toasterAlphaLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toasterAlphaLevel.Location = new System.Drawing.Point(230, 65);
            this.toasterAlphaLevel.Name = "toasterAlphaLevel";
            this.toasterAlphaLevel.Size = new System.Drawing.Size(101, 20);
            this.toasterAlphaLevel.TabIndex = 2;
            this.toasterAlphaLevel.Enter += new System.EventHandler(this.toasterAlphaLevelToolTip);
            this.toasterAlphaLevel.Validating += new System.ComponentModel.CancelEventHandler(this.toasterAlphaLevelValidation);
            // 
            // toasterAlphaLevelLabel
            // 
            this.toasterAlphaLevelLabel.Location = new System.Drawing.Point(3, 60);
            this.toasterAlphaLevelLabel.Name = "toasterAlphaLevelLabel";
            this.toasterAlphaLevelLabel.Size = new System.Drawing.Size(221, 30);
            this.toasterAlphaLevelLabel.TabIndex = 6;
            this.toasterAlphaLevelLabel.Text = "Toaster Alpha Level (Transperancy):";
            this.toasterAlphaLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundColor
            // 
            this.backgroundColor.Location = new System.Drawing.Point(230, 93);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(87, 23);
            this.backgroundColor.TabIndex = 8;
            this.backgroundColor.Text = "Choose Color";
            this.backgroundColor.UseVisualStyleBackColor = true;
            this.backgroundColor.Click += new System.EventHandler(this.onBackgroundColorClick);
            // 
            // foregroundColor
            // 
            this.foregroundColor.Location = new System.Drawing.Point(230, 123);
            this.foregroundColor.Name = "foregroundColor";
            this.foregroundColor.Size = new System.Drawing.Size(87, 23);
            this.foregroundColor.TabIndex = 9;
            this.foregroundColor.Text = "Choose Color";
            this.foregroundColor.UseVisualStyleBackColor = true;
            this.foregroundColor.Click += new System.EventHandler(this.onForegroundColorClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(289, 189);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save Changes";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.onSave);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(12, 189);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.onCancel);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(402, 224);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Toaster Options";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox toasterNotificationPopupSpeed;
        private System.Windows.Forms.Label toasterNotificationPopupSpeedLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox toasterNotificationDuration;
        private System.Windows.Forms.Label toasterNotificationDurationLabel;
        private System.Windows.Forms.Label toasterBackgroundColorLabel;
        private System.Windows.Forms.TextBox toasterAlphaLevel;
        private System.Windows.Forms.Label toasterAlphaLevelLabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.Label toasterForegroundColorLabel;
        private System.Windows.Forms.Button foregroundColor;
    }
}