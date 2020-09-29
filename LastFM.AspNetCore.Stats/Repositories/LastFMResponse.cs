using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    public class LastFMResponse
    {
        public bool IsSuccessful { get; set; }

        public Task<string> Message { get; set; }

        public LastFMResponse(HttpResponseMessage response)
        {
            IsSuccessful = response.IsSuccessStatusCode;
            Message = response.Content.ReadAsStringAsync();
        }
    }
}
