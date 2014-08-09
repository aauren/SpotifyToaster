SpotifyToaster
==============

Presents toast notifications (system tray popups) when Spotify changes songs

## Background
I'm an avid Spotify user, but I've always felt that it was missing a way to identify the songs as they changed. Other applications like Windows Media Player or Winamp had the option of displaying toast notifications which I always referred to as System Tray Popups that would be displayed when a new song started. These notifications would appear near the clock on the Windows Menu Bar and give you the name of the artist, albumn, track number, and track title along with the albumn art.

So with this project I've attempted to recreate those notifications for Spotify within a Windows environment. If you're like me and you miss those popups as well, feel free to use this application.

## Credits
##### [Ranveer Raghuwanshi](https://github.com/ranveer5289) - http://stackoverflow.com/users/776084/ranrag
When I first started this project, the first thing I did was look around to see if anything like this already existed. In fact,  had already done a great job of producing this same functionality for Growl, Snarl, and Notifu in his application [spotifynotifier](https://code.google.com/p/spotifynotifier/). The only problem is that I had no other need for these notification frameworks and felt that they were a bit heavy for my use case.

So as the application is now most of the work of getting the current track, artist, and eventually albumn art is derrivitive from his application. My original work mostly comes in with some refactoring that I did and the actual mechanism that displays the toast notification.

##### aku - http://stackoverflow.com/users/1196/aku
My first ideas of how to animate a toast notification came from [his post on StackExchange](http://stackoverflow.com/questions/461184/toast-style-popup-for-my-application)

## Pre-requisites
A Windows based operating system. I've currently only tested it with Windows 7, but it should run on other versions of Windows as well. I would be grateful for any testing others are willing to do.

## Installation
Currently, the application is only a simple .exe file so you need only copy it to your computer and double-click it to get it going.

The compiled application lives in the bin folder, to make it easier though, you can:

**[Download The Application Here](https://github.com/aauren/SpotifyToaster/blob/master/bin/Release/SpotifyToaster.exe)**

You don't need to have Spotify running in order to start the application. If everything went well, you should see something similar to [this](https://github.com/aauren/SpotifyToaster/blob/master/images/toastStartupNotificationExample.png). The next time you start Spotify and begin playing music, the application will begin notifying you of the songs being played.

## Known Issues
If you have any questions about how this application works, or any problems please check the [issues](https://github.com/aauren/SpotifyToaster/issues) section first to see if your problem is already mentioned there.

## Contribution
I welcome any help people are willing to give just submit a pull request. In the future, I'll put more information here on how to build this application, but for right now if you have Visual Studio you should be fine.
