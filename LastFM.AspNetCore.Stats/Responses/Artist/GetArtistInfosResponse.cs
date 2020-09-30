using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.Artist
{
    internal class GetArtistInfosResponse : GetResponse<GetArtistInfosResponse>
    {
        [JsonProperty("artist")]
        public ArtistModel Artist { get; set; }
    }
}