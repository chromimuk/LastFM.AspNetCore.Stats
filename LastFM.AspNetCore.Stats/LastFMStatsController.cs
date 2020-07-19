using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats
{
    public class LastFMStatsController
    {
        private readonly ILastFMUserService _lastFMUserService;

        public LastFMStatsController(LastFMCredentials credentials)
        {
            if (credentials == null)
                throw new Exception("Invalid credentials");

            LastFMServiceFactory lastFMServiceFactory = new LastFMServiceFactory(credentials);
            _lastFMUserService = lastFMServiceFactory.GetLastFMUserService();
        }

        public Task<LastFMUser> GetUserInfo(string username)
        {
            return _lastFMUserService.GetInfosAsync(username);
        }
    }
}
