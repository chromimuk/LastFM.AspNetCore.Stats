using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Services;
using LastFM.AspNetCore.Stats.Services.Interfaces;
using LastFM.AspNetCore.Stats.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats
{
    public class LastFMStatsController
    {
        private readonly ILastFMUserService _lastFMUserService;
        private readonly ILastFMArtistService _lastFMArtistService;
        private readonly ILastFMAlbumService _lastFMAlbumService;

        public LastFMStatsController(LastFMCredentials credentials)
        {
            if (credentials == null)
                throw new InvalidCredentialsException();

            LastFMServiceFactory lastFMServiceFactory = new LastFMServiceFactory(credentials);
            _lastFMUserService = lastFMServiceFactory.GetLastFMUserService();
            _lastFMArtistService = lastFMServiceFactory.GetLastFMArtistService();
            _lastFMAlbumService = lastFMServiceFactory.GetLastFMAlbumService();
        }

        #region User

        public Task<LastFMUser> GetUserInfo(string username)
        {
            return _lastFMUserService.GetInfoAsync(username);
        }

        public Task<IEnumerable<Track>> GetUserLovedTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetLovedTracksAsync(username, limit);
        }

        public Task<IEnumerable<Track>> GetUserRecentTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetRecentTracksAsync(username, limit);
        }

        public Task<IEnumerable<Album>> GetUserTopAlbums(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopAlbumsAsync(username, limit);
        }

        public Task<IEnumerable<Artist>> GetUserTopArtists(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopArtistsAsync(username, limit);
        }

        public Task<IEnumerable<Track>> GetUserTopTracks(string username, int limit = 10)
        {
            return _lastFMUserService.GetTopTracksAsync(username, limit);
        }

        #endregion User

        #region Artist

        public Task<Artist> GetArtistInfo(string searchedArtist)
        {
            return _lastFMArtistService.GetInfoAsync(searchedArtist);
        }

        public Task<IEnumerable<Artist>> GetSimilarArtists(string searchedArtist, int limit = 10)
        {
            return _lastFMArtistService.GetSimilarArtistsAsync(searchedArtist, limit);
        }

        public Task<IEnumerable<Album>> GetArtistTopAlbums(string searchedArtist, int limit = 10)
        {
            return _lastFMArtistService.GetTopAlbumsAsync(searchedArtist, limit);
        }

        public Task<IEnumerable<Track>> GetArtistTopTracks(string searchedArtist, int limit = 10)
        {
            return _lastFMArtistService.GetTopTracksAsync(searchedArtist, limit);
        }

        #endregion

        #region Album

        public Task<Album> GetAlbumInfo(string artistName, string albumName)
        {
            return _lastFMAlbumService.GetInfoAsync(artistName, albumName);
        }

        #endregion
    }
}