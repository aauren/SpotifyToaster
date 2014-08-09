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
using Metadata;
using Notification;
using spotifytoaster;


class NameChangeTracker
{
    // Initializing Fields
    private const uint EVENT_OBJECT_CREATE = 0x00008000;

    private static Notify notify;
    private static TrackMetadata tmd;
    private static ProcessInformation psi;
    private static ToastForm myForm;
    private static IntPtr hWinEventHook;
    private static IntPtr hWinEventHook_start;

    // Need to ensure delegate is not collected while we're using it,
    // storing it in a class field is simplest way to do this.
    private static WinEventDelegate procDelegate = new WinEventDelegate(NameChangeTracker.WinEventProc);
    private static WinEventDelegate procDelegate_start = new WinEventDelegate(NameChangeTracker.WinEventProc_start);
    private delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int
                    idChild, uint dwEventThread, uint dwmsEventTime);

    //Dll Imports
    [DllImport("user32")]
    internal static extern bool GetMessage(ref Message lpMsg, IntPtr handle, uint mMsgFilterInMain, uint mMsgFilterMax);
    [DllImport("user32.dll")]
    private static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc,
                    WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);
    [DllImport("user32.dll")]
    private static extern bool UnhookWinEvent(IntPtr hWinEventHook);

    //Constructor for NameChangeTracker
    public NameChangeTracker(ToastForm myForm)
    {
        NameChangeTracker.myForm = myForm;
        psi = new ProcessInformation();
        tmd = new TrackMetadata();
        notify = new Notify();
        Console.WriteLine(psi.getSpotifyPID());

        // Listen for name change changes for spotify(check pid!=0).
        hWinEventHook = SetWinEventHook(0x0800c, 0x800c, IntPtr.Zero, procDelegate, Convert.ToUInt32(psi.getSpotifyPID()), 0, 0);
        // Listen for create window event across all processes/threads on current desktop.(check pid=0)
        hWinEventHook_start = SetWinEventHook(0x00008000, 0x00008000, IntPtr.Zero, procDelegate_start, 0, 0, 0);
    }

    public void removeWindowHooks()
    {
        Console.WriteLine("Removing Window Hooks");
        UnhookWinEvent(hWinEventHook);
        UnhookWinEvent(hWinEventHook_start);
    }

    private static void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint
                    dwEventThread, uint dwmsEventTime)
    {
        if ((idObject == 0) && (idChild == 0))
        {
            if (psi.isSpotifyAvailable() && hwnd.ToInt32() == psi.getSpotifyWindowHandle().ToInt32())
            {
                string track = tmd.getTrack();
                string artist = tmd.getArtist();

                if (track != null || artist != null)
                {
                    Console.WriteLine(artist + " - " + track);
                    notify.showViaToast(myForm, track, artist);
                    Console.WriteLine("Finished Showing");
                }
            }
        }
    }

    private static void WinEventProc_start(IntPtr hWinEventHook_start, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
    {
        if (idObject == 0 && idChild == 0)
        {
            //specifically looking for spotify via hwnd_spotify
            //across all process(hwnd).
            if (psi.isSpotifyAvailable() && hwnd.ToInt32() == psi.getSpotifyWindowHandle().ToInt32())
            {
                Console.WriteLine("checking hwnd");
                if (eventType == EVENT_OBJECT_CREATE)
                {
                    Console.WriteLine("create event");
                    IntPtr hWinEventHook = SetWinEventHook(0x0800c, 0x800c, IntPtr.Zero, procDelegate, Convert.ToUInt32(psi.getSpotifyPID()), 0, 0);
                }
            }
        }
    }

    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new ToastForm());
    }
}