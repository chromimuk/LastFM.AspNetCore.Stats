using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    public class LinkModelCollection
    {
        [JsonProperty("link")]
        public LinkModel Link { get; set; }
    }
}