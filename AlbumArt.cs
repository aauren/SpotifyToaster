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
    class AlbumArt
    {
        private String lastFmUrlTemplate = "http://ws.audioscrobbler.com/2.0/?method=track.getinfo&api_key={0}&artist={1}&track={2}";

        private String getLastFMAPIKey()
        {
            return spotifytoaster.Properties.ProtectedResources.lastFmAPIKey;
        }

        /*
         * Get's a 64x64 pixel image URL reference for the artist and track supplied
         */
        public String getImageUrl(String artist, String track)
        {
            try
            {
                String url = String.Format(lastFmUrlTemplate, getLastFMAPIKey(), artist, track);
                Console.WriteLine("Fetching from URL: " + url);
                XPathDocument doc = new XPathDocument(url);

                XPathNavigator navigator = doc.CreateNavigator();
                XPathNavigator nodeImage = navigator.SelectSingleNode("/lfm/track/album/image[@size='medium']");
                if (null != nodeImage)
                {
                    return nodeImage.InnerXml;
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        public static void Main()
        {
            AlbumArt albumArt = new AlbumArt();
            Console.WriteLine("Last FM API Key: " + albumArt.getLastFMAPIKey());
            Console.WriteLine("Image URL for Owl City - Angels: " + albumArt.getImageUrl("Owl City", "Angels"));
        }
    }
}