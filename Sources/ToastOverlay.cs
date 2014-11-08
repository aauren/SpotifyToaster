using spotifytoaster.Sources;
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
    public partial class ToastOverlay : Form
    {
        private Options myOptions;
        private String album;
        private String artist;
        private String trackName;

        public ToastOverlay()
        {
            InitializeComponent();
        }

        internal void initializeFormSettings(Options myOptions)
        {
            this.myOptions = myOptions;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            paintText(album, 80.0F, 10.0F, e);
            paintText(artist, 80.0F, 34.0F, e);
            paintText(trackName, 80.0F, 57.0F, e);
        }

        private void paintText(String text, float x, float y, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            System.Drawing.Font drawFont = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(myOptions.ToastForegroundColor);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            e.Graphics.DrawString(text, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

        internal void setAlbumnText(String text)
        {
            album = text;
        }

        internal void setArtistText(String text)
        {
            artist = text;
        }

        internal void setTrackName(String text)
        {
            trackName = text;
        }
    }
}
