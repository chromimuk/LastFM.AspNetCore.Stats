using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class AlbumWithTracksModel
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("image")]
        public List<ImageModel> Image { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("listeners")]
        public long Listeners { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tracks")]
        public TrackModelCollection Tracks { get; set; }

        [JsonProperty("tags")]
        public TagModelCollection Tags { get; set; }
    }
}