using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetErrorResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public static GetErrorResponse FromJson(string json) => JsonConvert.DeserializeObject<GetErrorResponse>(json, Converter.Settings);
    }
}