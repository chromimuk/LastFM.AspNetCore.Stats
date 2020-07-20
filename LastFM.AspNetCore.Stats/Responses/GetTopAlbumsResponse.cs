using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetTopAlbumsResponse
    {
        [JsonProperty("topalbums")]
        public AlbumCollection TopAlbums { get; set; }

        public static GetTopAlbumsResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTopAlbumsResponse>(json, Converter.Settings);
    }
}