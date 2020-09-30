using System;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Bio
    {
        public Uri Link { get; set; }

        public string Published { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }
    }
}