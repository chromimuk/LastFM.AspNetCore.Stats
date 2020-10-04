using Newtonsoft.Json;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class TagModelCollection
    {
        [JsonProperty("tag")]
        public List<TagModel> Tags { get; set; }
    }
}