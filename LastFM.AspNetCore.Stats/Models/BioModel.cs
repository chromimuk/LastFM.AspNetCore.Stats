using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class BioModel
    {
        [JsonProperty("links")]
        public LinkModelCollection Links { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}