using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace spotifytoaster.Sources
{
    public class Options
    {
        private const int MOVEMENT_SPEED = 25;
        private const int TIME_TO_LIVE = 5000;
        private const double ALPHA_LEVEL = .9;
        private const int BACKGROUND_COLOR_ARBG = -16777216;
        private const int FOREGROUND_COLOR_ARBG = -6632142;

        private int toastMovementSpeed;
        private int toastTimeToLive;
        private Color toastBackgroundColor;
        private double toastAlphaLevel;
        private Color toastForegroundColor;

        public Options()
        {
            loadOptionsFromSettings();
        }

        private void loadOptionsFromSettings()
        {
            // Check if any settings exist yet
            if (null == Properties.Settings.Default)
            {
                initializeSettings();
                return;
            }

            // The following makes sure that each individual settings exists, and if it is
            // missing, set it back to default.
            toastMovementSpeed = (int)Properties.Settings.Default["ToastMovementSpeed"];
            if (0 == toastMovementSpeed)
            {
                toastMovementSpeed = MOVEMENT_SPEED;
            }

            toastTimeToLive = (int)Properties.Settings.Default["ToastTimeToLive"];
            if (0 == toastTimeToLive)
            {
                toastTimeToLive = TIME_TO_LIVE;
            }

            toastAlphaLevel = (double)Properties.Settings.Default["ToastAlphaLevel"];
            if (0 == toastAlphaLevel)
            {
                toastAlphaLevel = ALPHA_LEVEL;
            }

            int backgroundColorARBG = (int)Properties.Settings.Default["ToastBackgroundColor"];
            if (0 == backgroundColorARBG)
            {
                backgroundColorARBG = BACKGROUND_COLOR_ARBG;
            }
            toastBackgroundColor = Color.FromArgb(backgroundColorARBG);

            int foregroundColorARBG = (int)Properties.Settings.Default["ToastForegroundColor"];
            if (0 == foregroundColorARBG)
            {
                foregroundColorARBG = FOREGROUND_COLOR_ARBG;
            }
            toastForegroundColor = Color.FromArgb(foregroundColorARBG);
        }

        private void initializeSettings()
        {
            toastMovementSpeed = MOVEMENT_SPEED;
            toastTimeToLive = TIME_TO_LIVE;
            toastBackgroundColor = Color.FromArgb(BACKGROUND_COLOR_ARBG);
            toastAlphaLevel = ALPHA_LEVEL;
            toastForegroundColor = Color.FromArgb(FOREGROUND_COLOR_ARBG);
        }

        public void saveSettings()
        {
            Properties.Settings.Default["ToastMovementSpeed"] = toastMovementSpeed;
            Properties.Settings.Default["ToastTimeToLive"] = toastTimeToLive;
            Properties.Settings.Default["ToastBackgroundColor"] = toastBackgroundColor.ToArgb();
            Properties.Settings.Default["ToastAlphaLevel"] = toastAlphaLevel;
            Properties.Settings.Default["ToastForegroundColor"] = toastForegroundColor.ToArgb();
            Properties.Settings.Default.Save();
        }

        public static String validateToastMovementSpeed(String speed)
        {
            return validateIntGreaterThanOne(speed);
        }

        public static String validateToastTimeToLive(String ttl)
        {
            return validateIntGreaterThanOne(ttl);
        }

        public static String validateToastAlphaLevel(String level)
        {
            double alphaLevel = 0;
            if (!double.TryParse(level, out alphaLevel))
            {
                return "Alpha level must be a decimal";
            }
            if (alphaLevel > 1 || alphaLevel < 0)
            {
                return "Alpha level must be between 0 and 1";
            }

            return null;
        }

        private static String validateIntGreaterThanOne(String potentialNumber)
        {
            int integer = 0;
            if (!int.TryParse(potentialNumber, out integer))
            {
                return "Popup speed must be an integer (number)";
            }
            if (integer < 1)
            {
                return "Popup speed must be greater than 1";
            }

            return null;
        }

        public int ToastMovementSpeed
        {
            get { return toastMovementSpeed; }
        }

        public void setToastMovementSpeed(String speed)
        {
            if (null == validateToastMovementSpeed(speed))
            {
                int tempInt = 0;
                int.TryParse(speed, out tempInt);
                toastMovementSpeed = tempInt;
            }
        }

        public int ToastTimeToLive
        {
            get { return toastTimeToLive; }
        }

        public void setToastTimeToLive(String ttl)
        {
            if (null == validateToastTimeToLive(ttl))
            {
                int tempInt = 0;
                int.TryParse(ttl, out tempInt);
                toastTimeToLive = tempInt;
            }
        }

        public double ToastAlphaLevel
        {
            get { return toastAlphaLevel; }
        }

        public void setToastAlphaLevel(String level)
        {
            if (null == validateToastAlphaLevel(level))
            {
                double tempDbl = 0;
                double.TryParse(level, out tempDbl);
                toastAlphaLevel = tempDbl;
            }
        }

        public Color ToastBackgroundColor
        {
            get { return toastBackgroundColor; }
            set { toastBackgroundColor = value; }
        }

        public Color ToastForegroundColor
        {
            get { return toastForegroundColor; }
            set { toastForegroundColor = value; }
        }
    }
}
