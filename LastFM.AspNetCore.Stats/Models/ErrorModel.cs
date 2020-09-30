using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    public class ErrorModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
