using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserTopTracksResponse : GetResponse<GetUserTopTracksResponse>
    {
        [JsonProperty("toptracks")]
        public TrackModelCollection TopTracks { get; set; }
    }
}