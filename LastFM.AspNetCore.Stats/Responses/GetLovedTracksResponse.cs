using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetLovedTracksResponse
    {
        [JsonProperty("lovedtracks")]
        public TrackCollection LovedTracks { get; set; }

        public static GetLovedTracksResponse FromJson(string json) => JsonConvert.DeserializeObject<GetLovedTracksResponse>(json, Converter.Settings);
    }
}