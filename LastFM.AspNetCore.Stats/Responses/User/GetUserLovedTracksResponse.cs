﻿using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json;

namespace LastFM.AspNetCore.Stats.Responses.User
{
    internal class GetUserLovedTracksResponse : GetResponse<GetUserLovedTracksResponse>
    {
        [JsonProperty("lovedtracks")]
        public TrackModelCollection LovedTracks { get; set; }
    }
}