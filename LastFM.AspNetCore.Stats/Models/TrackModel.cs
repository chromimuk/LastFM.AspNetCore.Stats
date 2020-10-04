using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class TrackModel
    {
        [JsonProperty("artist")]
        public ArtistModel Artist { get; set; }

        [JsonProperty("mbid")]
        public string Mbid { get; set; }

        [JsonProperty("date")]
        public DateModel Date { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public IEnumerable<ImageModel> Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("album")]
        public AlbumModel Album { get; set; }
    }
}