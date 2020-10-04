using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services
{
    internal class LastFMUserService : ILastFMUserService
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

        public async Task<IEnumerable<Track>> GetLovedTracksAsync(string username, int limit = 10)
        {
            return await _userRepository.GetLovedTracksAsync(username, limit);
        }

        public async Task<IEnumerable<Track>> GetRecentTracksAsync(string username, int limit = 10)
        {
            return await _userRepository.GetRecentTracksAsync(username, limit);
        }

        public async Task<IEnumerable<Album>> GetTopAlbumsAsync(string username, int limit = 10)
        {
            return await _userRepository.GetTopAlbumsAsync(username, limit);
        }

        public async Task<IEnumerable<Artist>> GetTopArtistsAsync(string username, int limit = 10)
        {
            return await _userRepository.GetTopArtistsAsync(username, limit);
        }

        public async Task<IEnumerable<Track>> GetTopTracksAsync(string username, int limit = 10)
        {
            return await _userRepository.GetTopTracksAsync(username, limit);
        }
    }
}