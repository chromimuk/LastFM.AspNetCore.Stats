using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetTopTracksResponse
    {
        [JsonProperty("toptracks")]
        public TrackModelCollection TopTracks { get; set; }

        public static GetTopTracksResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTopTracksResponse>(json, Converter.Settings);
    }
}