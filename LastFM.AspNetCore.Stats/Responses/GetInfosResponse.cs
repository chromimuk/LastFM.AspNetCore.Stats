using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetInfosResponse
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }

        public static GetInfosResponse FromJson(string json) => JsonConvert.DeserializeObject<GetInfosResponse>(json, Converter.Settings);
    }
}