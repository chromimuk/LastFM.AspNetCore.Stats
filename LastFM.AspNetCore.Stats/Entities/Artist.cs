using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Entities
{
    public class Artist
    {
        public Uri Url { get; set; }

        public string Name { get; set; }

        public IEnumerable<Image> Images { get; set; }

        public bool Streamable { get; set; }

        public bool Ontour { get; set; }

        public Statistics Statistics { get; set; }

        public IEnumerable<Artist> SimilarArtists { get; set; }

        public IEnumerable<Tag> Tags { get; set; }

        public Bio Bio { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}