﻿using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserTopAlbumsResponse : GetResponse<GetUserTopAlbumsResponse>
    {
        [JsonProperty("topalbums")]
        public AlbumModelCollection TopAlbums { get; set; }
    }
}