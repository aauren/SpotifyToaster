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

namespace ProcessInfo
{
    //Dll Imports.
    internal class DLL_Methods
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32")]
        internal static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);
    }

    class ProcessInformation
    {
        //Returns handle to the spotify window.
        public IntPtr getSpotifyWindowHandle()
        {
            return DLL_Methods.FindWindow("SpotifyMainWindow", null);
        }

        //Returns the PID for spotify application.
        public int getSpotifyPID()
        {
            int processId = 0;
            int windowThreadProcessId = DLL_Methods.GetWindowThreadProcessId(getSpotifyWindowHandle(), out processId);
            return processId;
        }

        //Check spotify running or not.
        public bool isSpotifyAvailable()
        {
            return (getSpotifyWindowHandle() != IntPtr.Zero);
        }
    }
}
