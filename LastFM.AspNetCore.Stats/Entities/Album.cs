using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Album
    {
        public string Name { get; set; }

        public Artist Artist { get; set; }

        public List<Image> Image { get; set; }

        public long Playcount { get; set; }

        public Uri Url { get; set; }
    }
}