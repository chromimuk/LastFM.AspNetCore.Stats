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

        public Task<IEnumerable<Track>> GetLovedTracks(string username)
        {
            return _lastFMUserService.GetLovedTracksAsync(username);
        }

        public Task<IEnumerable<Track>> GetRecentTracks(string username)
        {
            return _lastFMUserService.GetRecentTracksAsync(username);
        }

        public Task<IEnumerable<Album>> GetTopAlbums(string username)
        {
            return _lastFMUserService.GetTopAlbumsAsync(username);
        }

        public Task<IEnumerable<Artist>> GetTopArtists(string username)
        {
            return _lastFMUserService.GetTopArtistsAsync(username);
        }

        public Task<IEnumerable<Track>> GetTopTracks(string username)
        {
            return _lastFMUserService.GetTopTracksAsync(username);
        }
    }
}