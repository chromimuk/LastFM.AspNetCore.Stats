﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class AlbumModelCollection
    {
        [JsonProperty("@attr")]
        public AttrModel Attr { get; set; }

        [JsonProperty("album")]
        public IEnumerable<AlbumModel> Albums { get; set; }
    }
}