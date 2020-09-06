using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    public abstract class LastFMRepository
    {
        protected const string BaseAddress = "http://ws.audioscrobbler.com/2.0/";

        protected readonly IMapper _mapper;
        protected readonly LastFMCredentials _lastFMCredentials;

        protected LastFMRepository(LastFMCredentials credentials, IMapper mapper)
        {
            _lastFMCredentials = credentials;
            _mapper = mapper;
        }

        protected async Task<string> Query(string url)
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri(BaseAddress) };
            client.DefaultRequestHeaders.Accept.Clear();

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }
    }
}