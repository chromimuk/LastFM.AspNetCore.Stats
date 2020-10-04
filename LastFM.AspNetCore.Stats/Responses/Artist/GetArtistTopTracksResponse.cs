using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.Artist
{
    internal class GetArtistTopTracksResponse : GetResponse<GetArtistTopTracksResponse>
    {
        [JsonProperty("toptracks")]
        public TrackModelCollection TopTracks { get; set; }
    }
}