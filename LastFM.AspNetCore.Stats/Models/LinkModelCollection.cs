using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class LinkModelCollection
    {
        [JsonProperty("link")]
        public LinkModel Link { get; set; }
    }
}