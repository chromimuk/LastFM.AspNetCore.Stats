using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class AttrModel
    {
        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Page { get; set; }

        [JsonProperty("total")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Total { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("perPage")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PerPage { get; set; }

        [JsonProperty("totalPages")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TotalPages { get; set; }
    }
}