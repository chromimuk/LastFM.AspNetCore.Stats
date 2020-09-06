using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats
{
    public class LastFMStatsController
    {
        private readonly ILastFMUserService _lastFMUserService;

        public LastFMStatsController(LastFMCredentials credentials)
        {
            if (credentials == null)
                throw new InvalidCredentialsException();

            LastFMServiceFactory lastFMServiceFactory = new LastFMServiceFactory(credentials);
            _lastFMUserService = lastFMServiceFactory.GetLastFMUserService();
        }

        public Task<LastFMUser> GetUserInfo(string username)
        {
            return _lastFMUserService.GetInfosAsync(username);
        }

        public Task<IEnumerable<Track>> GetLovedTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetLovedTracksAsync(username, limit);
        }

        public Task<IEnumerable<Track>> GetRecentTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetRecentTracksAsync(username, limit);
        }

        public Task<IEnumerable<Album>> GetTopAlbums(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopAlbumsAsync(username, limit);
        }

        public Task<IEnumerable<Artist>> GetTopArtists(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopArtistsAsync(username, limit);
        }

        public Task<IEnumerable<Track>> GetTopTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopTracksAsync(username, limit);
        }
    }
}