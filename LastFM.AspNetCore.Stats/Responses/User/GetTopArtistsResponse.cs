using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetTopArtistsResponse : GetResponse<GetTopArtistsResponse>
    {
        [JsonProperty("topartists")]
        public ArtistModelCollection TopArtists { get; set; }
    }
}