using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Models;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats
{
    public class UserRepository
    {
        private const string baseAddress = "http://ws.audioscrobbler.com/2.0/";

        private LastFMCredentials _lastFMCredentials;
        private readonly IMapper mapper;

        public UserRepository(IMapper mapper)
        {
            string apiKey = "";
            string sharedSecret = "";
            _lastFMCredentials = new LastFMCredentials(apiKey, sharedSecret);
            this.mapper = mapper;
        }

        public async Task<LastFMUser> GetInfosAsync()
        {
            string username = "chromimuk";
            string userGetUserInfoURL = $"/2.0/?method=user.getinfo&user={username}&api_key={_lastFMCredentials.APIKey}&format=json";
            Task<string> data = Query(userGetUserInfoURL);
            string jsonString = await data;

            GetInfosResponse getInfosResponse = GetInfosResponse.FromJson(jsonString);
            LastFMUser user = mapper.Map<LastFMUser>(getInfosResponse.User);
            return user;
        }


        private async Task<string> Query(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
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
}



//public static class Serialize
//{
//    public static string ToJson(this GetInfosResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
//}



