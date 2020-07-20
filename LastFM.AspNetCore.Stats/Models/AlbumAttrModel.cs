using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    public class AlbumAttrModel
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}