﻿using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserInfosResponse : GetResponse<GetUserInfosResponse>
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }
    }
}