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

        public ToastForm()
        {
            InitializeComponent();

            // Create and run timer for animation
            timer = new Timer();
            timer.Interval = 25;
            timer.Tick += new EventHandler(timer_Tick);

            // Now let's setup our Spotify Window tracker
            nct = new NameChangeTracker(this);
        }

        private void ToastForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Move window out of screen
                startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
                startPosY = Screen.PrimaryScreen.WorkingArea.Height;
                SetDesktopLocation(startPosX, startPosY);
                base.OnLoad(e);
                // Begin animation
                timer.Enabled = true;
                timer.Start();
            }
        }

        void timer_Tick(object sender, EventArgs e)
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

        private void ToastForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form Close Detected");
            nct.removeWindowHooks();
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
