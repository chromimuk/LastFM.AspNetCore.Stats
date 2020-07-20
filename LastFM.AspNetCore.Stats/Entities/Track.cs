using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Track
    {
        public Artist Artist { get; set; }

        public Uri Url { get; set; }

        public IEnumerable<Image> Image { get; set; }

        public string Name { get; set; }

        public Album Album { get; set; }
    }
}