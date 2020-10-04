using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class ErrorModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
