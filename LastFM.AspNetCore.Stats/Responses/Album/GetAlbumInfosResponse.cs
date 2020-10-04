using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.Album
{
    internal class GetAlbumInfosResponse : GetResponse<GetAlbumInfosResponse>
    {
        [JsonProperty("album")]
        public AlbumWithTracksModel Album { get; set; }
    }
}