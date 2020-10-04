using System.Net.Http;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    internal class LastFMResponse
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
