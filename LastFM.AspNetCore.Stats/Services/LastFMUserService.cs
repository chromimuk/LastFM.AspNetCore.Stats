﻿using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services
{
    public class LastFMUserService : ILastFMUserService
    {
        private readonly IUserRepository _userRepository;

        public LastFMUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LastFMUser> GetInfosAsync(string username)
        {
            return await _userRepository.GetInfosAsync(username);
        }
    }
}