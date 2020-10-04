using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class DateModel
    {
        [JsonProperty("uts")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Uts { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }
    }
}