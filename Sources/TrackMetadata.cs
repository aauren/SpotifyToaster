/* Author: Aaron U'Ren
 * Email: aauren@gmail.com
 * Date: 8/8/2014
 * 
 * My version of this file was HEAVILY inspired by:
 * spotifynotifier: https://code.google.com/p/spotifynotifier/
 * Created By: Ranveer Raghuwanshi - ranveer.raghu@gmail.com - http://stackoverflow.com/users/776084/ranrag
 */

using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProcessInfo;

namespace Metadata
{
    //DLL Imports.
    internal class DLL_Methods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowTextLength(IntPtr hWnd);
    }


    class TrackMetadata
    {
        //Initializing Fields
        public ProcessInformation psi = null;

        //Constructor
        public TrackMetadata()
        {
            psi = new ProcessInformation();
        }


        public string GetCurrentTrack()
        {
            //Retrieves the length, in characters, of the specified window's title bar text 
            int length = DLL_Methods.GetWindowTextLength(psi.getSpotifyWindowHandle());
            StringBuilder sb = new StringBuilder(length + 1);
            //Copies the text of the specified window's title bar (if it has one) into a buffer
            DLL_Methods.GetWindowText(psi.getSpotifyWindowHandle(), sb, sb.Capacity);

            return sb.ToString().Replace("Spotify", "").TrimStart(' ', '-').Trim();
        }

        //Returns track info in an array.
        public string[] getCurrentTrackInfo()
        {
            string[] strArray = null;
            string currentTrack = null;
            currentTrack = GetCurrentTrack();

            if (!string.IsNullOrEmpty(currentTrack))
            {
                if (currentTrack.IndexOf('-') >= 0)
                {
                    strArray = currentTrack.Split('-');
                }
                else
                {
                    strArray = currentTrack.Split('\u2013');
                }
            }
            else
                return null;

            return strArray;
        }

        //Returns track/song name.
        public string getTrack()
        {
            if (getCurrentTrackInfo() == null || getCurrentTrackInfo().Length == 0)
                return null;
            else
                return getCurrentTrackInfo()[1].Trim();

        }

        //Returns artist name.
        public string getArtist()
        {
            if (getCurrentTrackInfo() == null || getCurrentTrackInfo().Length == 0)
                return null;
            else
                return getCurrentTrackInfo()[0].Trim();
        }

    }
}
