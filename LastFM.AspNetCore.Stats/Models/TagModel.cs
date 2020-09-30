using Newtonsoft.Json;
using System;

namespace LastFM.AspNetCore.Stats.Models
{
    public class TagModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}