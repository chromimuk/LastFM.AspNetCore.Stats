using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.Artist
{
    internal class GetSimilarArtistResponse : GetResponse<GetSimilarArtistResponse>
    {
        [JsonProperty("similarartists")]
        public ArtistModelCollection SimilarArtists { get; set; }
    }
}