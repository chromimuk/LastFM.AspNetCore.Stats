using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetTopTracksResponse
    {
        [JsonProperty("toptracks")]
        public TrackCollection TopTracks { get; set; }

        public static GetTopTracksResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTopTracksResponse>(json, Converter.Settings);
    }
}