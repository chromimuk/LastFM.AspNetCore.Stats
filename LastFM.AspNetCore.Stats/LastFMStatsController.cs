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
        private readonly LastFMCredentials _credentials;
        private readonly ILastFMUserService _lastFMUserService;

        public LastFMStatsController(LastFMCredentials credentials, ILastFMUserService lastFMUserService)
        {
            _credentials = credentials;
            _lastFMUserService = lastFMUserService;
        }

        public Task<LastFMUser> GetUserInfo(string username)
        {
            return _lastFMUserService.GetInfosAsync(username);
        }
    }
}
