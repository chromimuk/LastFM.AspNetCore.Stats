using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.Artist
{
    internal class GetArtistTopAlbumsResponse : GetResponse<GetArtistTopAlbumsResponse>
    {
        [JsonProperty("topalbums")]
        public AlbumModelCollection TopAlbums { get; set; }
    }
}