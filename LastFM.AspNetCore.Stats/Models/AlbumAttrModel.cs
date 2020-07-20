using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastFM.AspNetCore.Stats.Models
{
    public class AlbumAttrModel
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}
