using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserTopArtistsResponse : GetResponse<GetUserTopArtistsResponse>
    {
        [JsonProperty("topartists")]
        public ArtistModelCollection TopArtists { get; set; }
    }
}