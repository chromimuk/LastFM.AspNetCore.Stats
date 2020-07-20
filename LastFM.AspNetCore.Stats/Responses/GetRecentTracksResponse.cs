using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetRecentTracksResponse
    {
        [JsonProperty("recenttracks")]
        public TrackCollection RecentTracks { get; set; }

        public static GetRecentTracksResponse FromJson(string json) => JsonConvert.DeserializeObject<GetRecentTracksResponse>(json, Converter.Settings);
    }
}