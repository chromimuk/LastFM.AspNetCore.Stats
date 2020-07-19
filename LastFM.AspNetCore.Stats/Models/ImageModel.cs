﻿using Newtonsoft.Json;
using System;

namespace LastFM.AspNetCore.Stats.Models
{
    public class ImageModel
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("#text")]
        public Uri Text { get; set; }
    }
}