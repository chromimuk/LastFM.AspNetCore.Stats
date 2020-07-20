using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastFM.AspNetCore.Stats.Models
{
    public class ArtistCollection
    {
        [JsonProperty("@attr")]
        public AttrModel Attr { get; set; }

        [JsonProperty("artist")]
        public IEnumerable<ArtistModel> Artists { get; set; }
    }
}
