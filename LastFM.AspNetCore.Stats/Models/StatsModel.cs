using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    public class StatsModel
    {
        [JsonProperty("listeners")]
        public long Listeners { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }
    }
}