using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class AlbumAttrModel
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}