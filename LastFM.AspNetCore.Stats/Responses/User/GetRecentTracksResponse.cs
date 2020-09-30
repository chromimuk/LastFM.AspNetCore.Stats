using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetRecentTracksResponse : GetResponse<GetRecentTracksResponse>
    {
        [JsonProperty("recenttracks")]
        public TrackModelCollection RecentTracks { get; set; }
    }
}