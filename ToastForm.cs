/* Author: Aaron U'Ren
 * Email: aauren@gmail.com
 * Date: 8/8/2014
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spotifytoaster
{
    public partial class ToastForm : Form
    {
        private Timer timer;
        private int startPosX;
        private int startPosY;
        private NameChangeTracker nct;
        private NotifyIcon trayIcon;

        public ToastForm()
        {
            InitializeComponent();

            // Create tray icon
            createTrayIconAndMenu();

            // Create and run timer for animation
            timer = new Timer();
            timer.Interval = 25;
            timer.Tick += new EventHandler(timerTick);

            // Now let's setup our Spotify Window tracker
            nct = new NameChangeTracker(this);
        }

        private void toastVisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Move window out of screen
                startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
                startPosY = Screen.PrimaryScreen.WorkingArea.Height;
                SetDesktopLocation(startPosX, startPosY);
                base.OnLoad(e);
                // Begin animation
                TopMost = true;
                timer.Enabled = true;
                timer.Start();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Console.WriteLine("Form Close Detected");
            nct.removeWindowHooks();
            trayIcon.Visible = false;
            Application.Exit();
        }

        void timerTick(object sender, EventArgs e)
        {
            //Lift window by 5 pixels
            startPosY -= 2;
            //If window is fully visible stop the timer
            if (startPosY < Screen.PrimaryScreen.WorkingArea.Height - Height)
            {
                timer.Stop();
                timer.Enabled = false;
                System.Threading.Thread.Sleep(5000);
                Hide();
            }
            else
            {
                SetDesktopLocation(startPosX, startPosY);
            }
        }

        private void createTrayIconAndMenu()
        {
            // Create a simple tray menu with only one item.
            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Spotify Toaster";
            trayIcon.Icon = new Icon(Icon.ExtractAssociatedIcon("SpotifyToaster.exe"), 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        public void setArtist(String text)
        {
            artistBox.Text = text;
        }

        public void setTrack(String text)
        {
            trackBox.Text = text;
        }
    }
}
