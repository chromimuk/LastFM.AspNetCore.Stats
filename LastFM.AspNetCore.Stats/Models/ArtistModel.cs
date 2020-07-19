using Newtonsoft.Json;
using System;

namespace LastFM.AspNetCore.Stats.Models
{
    public partial class ArtistModel
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mbid")]
        public Guid Mbid { get; set; }
    }
}