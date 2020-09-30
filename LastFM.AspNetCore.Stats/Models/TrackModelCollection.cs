using Newtonsoft.Json;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    public partial class TrackModelCollection
    {
        [JsonProperty("@attr")]
        public AttrModel Attr { get; set; }

        [JsonProperty("track")]
        public IEnumerable<TrackModel> Tracks { get; set; }
    }
}