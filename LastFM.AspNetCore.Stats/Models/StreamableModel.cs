using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    public partial class StreamableModel
    {
        [JsonProperty("fulltrack")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Fulltrack { get; set; }

        [JsonProperty("#text")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Text { get; set; }
    }
}