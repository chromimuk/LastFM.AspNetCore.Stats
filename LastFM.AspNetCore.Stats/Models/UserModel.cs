using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class UserModel
    {
        [JsonProperty("playlists")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Playlists { get; set; }

        [JsonProperty("playcount")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Playcount { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subscriber")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Subscriber { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("image")]
        public List<ImageModel> Image { get; set; }

        [JsonProperty("registered")]
        public RegisteredModel Registered { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("age")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Age { get; set; }

        [JsonProperty("bootstrap")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Bootstrap { get; set; }

        [JsonProperty("realname")]
        public string Realname { get; set; }
    }
}