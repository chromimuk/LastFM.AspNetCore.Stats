using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetLovedTracksResponse : GetResponse<GetLovedTracksResponse>
    {
        [JsonProperty("lovedtracks")]
        public TrackModelCollection LovedTracks { get; set; }
    }
}