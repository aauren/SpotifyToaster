using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml.XPath;

namespace spotifytoaster
{
    /*
     * In order for you to be able to use this class you MUST first setup a string resource
     * named lastFmAPIKey. Go into the project's properties, go the the "Resources" tab, and
     * add the values that you received from LastFM: http://www.last.fm/api. This Resource file
     * should be called ProtectedResources
     */
    class AlbumInfo
    {
        private const String lastFmUrlTemplate = "http://ws.audioscrobbler.com/2.0/?method=track.getinfo&api_key={0}&artist={1}&track={2}";
        private const String smallImageXpath = "/lfm/track/album/image[@size='medium']";
        private const String albumTitleXpath = "/lfm/track/album/title";
        private const String trackNumberXpath = "/lfm/track/album";
        private XPathNavigator navigator;

        private String getLastFMAPIKey()
        {
            return spotifytoaster.Properties.ProtectedResources.lastFmAPIKey;
        }

        /*
         * Get's a 64x64 pixel image URL reference for the artist and track supplied
         */
        public Boolean loadAlbumInfo(String artist, String track)
        {
            try
            {
                String url = String.Format(lastFmUrlTemplate, getLastFMAPIKey(),
                    Uri.EscapeDataString(artist), Uri.EscapeDataString(track));
                //Console.WriteLine("Fetching from URL: " + url);
                XPathDocument doc = new XPathDocument(url);

                navigator = doc.CreateNavigator();
                return null != navigator;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public String getAlbumImageURL()
        {
            if (null != navigator)
            {
                XPathNavigator nodeImage = navigator.SelectSingleNode(smallImageXpath);
                if (null != nodeImage)
                {
                    return nodeImage.InnerXml;
                }
            }

            return null;
        }

        public String getAlbumTitle()
        {
            if (null != navigator)
            {
                XPathNavigator nodeTitle = navigator.SelectSingleNode(albumTitleXpath);
                if (null != nodeTitle)
                {
                    return nodeTitle.InnerXml;
                }
            }

            return null;
        }

        public String getTrackNumber()
        {
            if (null != navigator)
            {
                XPathNavigator nodeTrackNumber = navigator.SelectSingleNode(trackNumberXpath);
                if (null != nodeTrackNumber)
                {
                    return nodeTrackNumber.GetAttribute("position", "");
                }
            }

            return null;
        }

        public static void Main()
        {
            AlbumInfo albumInfo = new AlbumInfo();
            //Console.WriteLine("Last FM API Key: " + albumArt.getLastFMAPIKey());
            albumInfo.loadAlbumInfo("The Chainsmokers", "#SELFIE");
            Console.WriteLine("Album Title: " + albumInfo.getAlbumTitle());
            Console.WriteLine("Track Number: " + albumInfo.getTrackNumber());
            Console.WriteLine("Image URL: " + albumInfo.getAlbumImageURL());
        }
    }
}