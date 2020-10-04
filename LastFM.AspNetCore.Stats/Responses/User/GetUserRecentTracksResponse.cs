using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserRecentTracksResponse : GetResponse<GetUserRecentTracksResponse>
    {
        [JsonProperty("recenttracks")]
        public TrackModelCollection RecentTracks { get; set; }
    }
}