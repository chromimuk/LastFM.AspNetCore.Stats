using Newtonsoft.Json;
using System;

namespace LastFM.AspNetCore.Stats.Models
{
    public class LinkModel
    {
        [JsonProperty("#text")]
        public string Text { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}