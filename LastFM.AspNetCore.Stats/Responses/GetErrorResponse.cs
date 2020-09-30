using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    internal class GetErrorResponse : GetResponse<GetErrorResponse>
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}