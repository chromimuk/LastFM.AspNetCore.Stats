using Newtonsoft.Json;
using System;

namespace LastFM.AspNetCore.Stats.Models
{
    public partial class AlbumModel
    {
        [JsonProperty("mbid")]
        public string Mbid { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }
    }
}
