using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Repositories;
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

    public partial class GetLovedTracksResponse
    {
        [JsonProperty("lovedtracks")]
        public LovedTracks LovedTracks { get; set; }

        public static GetLovedTracksResponse FromJson(string json) => JsonConvert.DeserializeObject<GetLovedTracksResponse>(json, Converter.Settings);
    }
}