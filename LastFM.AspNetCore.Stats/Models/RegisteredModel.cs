using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class RegisteredModel
    {
        [JsonProperty("unixtime")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Unixtime { get; set; }

        [JsonProperty("#text")]
        public long Text { get; set; }
    }
}