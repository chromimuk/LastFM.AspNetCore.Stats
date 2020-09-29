using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastFM.AspNetCore.Stats.Models
{
    public class ErrorModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
