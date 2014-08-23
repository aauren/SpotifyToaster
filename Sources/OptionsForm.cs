using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spotifytoaster.Sources
{
    public partial class OptionsForm : Form
    {
        private const String POPUP_SPEED_TOOL_TIP = "How fast the popup moves into position. lower value = faster, higher value = slower";
        private const String POPUP_DURATION_TOOL_TIP = "Number of seconds notification will stay active in milliseconds";
        private const String ALPHA_LEVEL_TOOL_TIP = "Controls the transparency/opacity of the notification. 1 = fully opaque, 0 = fully transparent";
        private const int TOOL_TIP_DURATION = 2000;

        private Color selectedBackgroundColor;
        private Color selectedForegroundColor;
        private Options myOptions;

        public OptionsForm(Options options)
        {
            InitializeComponent();
            this.myOptions = options;
            setFieldsFromOptions();
        }

        private void setFieldsFromOptions()
        {
            toasterNotificationPopupSpeed.Text = myOptions.ToastMovementSpeed.ToString();
            toasterNotificationDuration.Text = myOptions.ToastTimeToLive.ToString();
            toasterAlphaLevel.Text = myOptions.ToastAlphaLevel.ToString();
            selectedBackgroundColor = myOptions.ToastBackgroundColor;
            selectedForegroundColor = myOptions.ToastForegroundColor;
        }

        private void setOptionsFromFields()
        {
            myOptions.setToastMovementSpeed(toasterNotificationPopupSpeed.Text);
            myOptions.setToastTimeToLive(toasterNotificationDuration.Text);
            myOptions.setToastAlphaLevel(toasterAlphaLevel.Text);
            myOptions.ToastBackgroundColor = selectedBackgroundColor;
            myOptions.ToastForegroundColor = selectedForegroundColor;
        }

        private void onSave(object sender, EventArgs e)
        {
            setOptionsFromFields();
            myOptions.saveSettings();

            this.Close();
        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onBackgroundColorClick(object sender, EventArgs e)
        {
            selectedBackgroundColor = createColorDialog(selectedBackgroundColor);
        }

        private void onForegroundColorClick(object sender, EventArgs e)
        {
            selectedForegroundColor = createColorDialog(selectedForegroundColor);
        }

        private Color createColorDialog(Color initialColor)
        {
            ColorDialog colorDiag = new ColorDialog();
            colorDiag.Color = initialColor;

            if (colorDiag.ShowDialog() == DialogResult.OK)
            {
                //save the colour that the user chose
                return colorDiag.Color;
            }

            return initialColor;
        }

        private void toasterPopupSpeedValidation(object sender, CancelEventArgs e)
        {
            String message = Options.validateToastMovementSpeed(toasterNotificationPopupSpeed.Text);
            showMessageAndCancelOnValidateError(message, e);
        }

        private void toasterDurationValidation(object sender, CancelEventArgs e)
        {
            String message = Options.validateToastMovementSpeed(toasterNotificationPopupSpeed.Text);
            showMessageAndCancelOnValidateError(message, e);
        }

        private void toasterAlphaLevelValidation(object sender, CancelEventArgs e)
        {
            String message = Options.validateToastAlphaLevel(toasterAlphaLevel.Text);
            showMessageAndCancelOnValidateError(message, e);
        }

        private void showMessageAndCancelOnValidateError(String message, CancelEventArgs e)
        {
            if (null != message)
            {
                MessageBox.Show(message);
                e.Cancel = true;
            }
        }

        private void toasterPopupSpeedToolTip(object sender, EventArgs e)
        {
            showToolTipForTextBox(toasterNotificationPopupSpeed, POPUP_SPEED_TOOL_TIP, TOOL_TIP_DURATION);
        }

        private void toasterDurationToolTip(object sender, EventArgs e)
        {
            showToolTipForTextBox(toasterNotificationDuration, POPUP_DURATION_TOOL_TIP, TOOL_TIP_DURATION);
        }

        private void toasterAlphaLevelToolTip(object sender, EventArgs e)
        {
            showToolTipForTextBox(toasterAlphaLevel, ALPHA_LEVEL_TOOL_TIP, TOOL_TIP_DURATION);
        }

        private void showToolTipForTextBox(TextBox control, String message, int visibleTime)
        {
            ToolTip tt = new ToolTip();
            tt.Show(message, control, visibleTime);
        }
    }
}
