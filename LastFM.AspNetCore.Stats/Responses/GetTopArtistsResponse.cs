using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public partial class GetTopArtistsResponse
    {
        [JsonProperty("topartists")]
        public ArtistCollection TopArtists { get; set; }

        public static GetTopArtistsResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTopArtistsResponse>(json, Converter.Settings);
    }
}