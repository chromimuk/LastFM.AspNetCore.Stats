using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LastFM.AspNetCore.Stats.Models
{
    internal class ArtistModel
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mbid")]
        public string Mbid { get; set; }

        [JsonProperty("image")]
        public List<ImageModel> Images { get; set; }

        [JsonProperty("streamable")]
        public long Streamable { get; set; }

        [JsonProperty("ontour")]
        public long Ontour { get; set; }

        [JsonProperty("stats")]
        public StatsModel Stats { get; set; }

        [JsonProperty("similar")]
        public ArtistModelCollection SimilarArtists { get; set; }

        [JsonProperty("tags")]
        public TagModelCollection Tags { get; set; }

        [JsonProperty("bio")]
        public BioModel Bio { get; set; }
    }
}