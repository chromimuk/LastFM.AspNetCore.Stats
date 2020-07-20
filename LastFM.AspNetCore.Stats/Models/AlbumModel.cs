using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    public partial class AlbumModel
    {
        [JsonProperty("mbid")]
        public string Mbid { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }

        [JsonProperty("artist")]
        public ArtistModel Artist { get; set; }

        [JsonProperty("@attr")]
        public AlbumAttrModel Attr { get; set; }

        [JsonProperty("image")]
        public List<ImageModel> Image { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
}