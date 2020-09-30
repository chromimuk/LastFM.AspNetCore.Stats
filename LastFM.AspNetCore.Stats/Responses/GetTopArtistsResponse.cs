using LastFM.AspNetCore.Stats.Models;
using LastFM.AspNetCore.Stats.Utils;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses
{
    public class GetTopArtistsResponse
    {
        [JsonProperty("topartists")]
        public ArtistModelCollection TopArtists { get; set; }

        public static GetTopArtistsResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTopArtistsResponse>(json, Converter.Settings);
    }

    public class GetArtistResponse
    {
        [JsonProperty("artist")]
        public ArtistModel Artist { get; set; }

        public static GetArtistResponse FromJson(string json) => JsonConvert.DeserializeObject<GetArtistResponse>(json, Converter.Settings);
    }
}