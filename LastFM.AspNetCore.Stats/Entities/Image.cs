using System;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Image
    {
        public Uri Uri { get; set; }

        public Image()
        {

        }

        public Image(Uri uri)
        {
            Uri = uri;
        }
    }
}