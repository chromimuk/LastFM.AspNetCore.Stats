using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class StatsModel
    {
        [JsonProperty("listeners")]
        public long Listeners { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }
    }
}