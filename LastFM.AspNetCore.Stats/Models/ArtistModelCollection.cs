﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class ArtistModelCollection
    {
        [JsonProperty("@attr")]
        public AttrModel Attr { get; set; }

        [JsonProperty("artist")]
        public IEnumerable<ArtistModel> Artists { get; set; }
    }
}