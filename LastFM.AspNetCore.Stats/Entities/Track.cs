using System;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Track
    {
        public Artist Artist { get; set; }

        public Uri Url { get; set; }

        public Image Image { get; set; }

        public string Name { get; set; }

        public Album Album { get; set; }

        public override string ToString()
        {
            return $"{Artist} - {Name}";
        }
    }
}