using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Entities
{
    public partial class LovedTracks
    {
        [JsonProperty("@attr")]
        public AttrModel Attr { get; set; }

        [JsonProperty("track")]
        public IEnumerable<TrackModel> Track { get; set; }
    }
}