using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    public class UserRepository : LastFMRepository, IUserRepository
    {
        public UserRepository(LastFMCredentials lastFMCredentials, IMapper mapper) : base(lastFMCredentials, mapper)
        {
        }

        public async Task<LastFMUser> GetInfosAsync(string username)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getinfo&user={username}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetInfosResponse tracks = GetInfosResponse.FromJson(jsonString);
            LastFMUser user = _mapper.Map<LastFMUser>(tracks.User);
            return user;
        }

        public async Task<IEnumerable<Track>> GetLovedTracksAsync(string username, int limit = 10)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getlovedtracks&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit={limit}";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get loved tracks ({error.Message})");
            }

            GetLovedTracksResponse response = GetLovedTracksResponse.FromJson(jsonString);
            IEnumerable<Track> tracks = _mapper.Map<IEnumerable<Track>>(response.LovedTracks.Tracks);
            return tracks;
        }

        public async Task<IEnumerable<Track>> GetRecentTracksAsync(string username, int limit = 10)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getrecenttracks&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit={limit}&extended=1";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get recent tracks ({error.Message})");
            }

            GetRecentTracksResponse response = GetRecentTracksResponse.FromJson(jsonString);
            IEnumerable<Track> tracks = _mapper.Map<IEnumerable<Track>>(response.RecentTracks.Tracks);
            return tracks;
        }

        public async Task<IEnumerable<Album>> GetTopAlbumsAsync(string username, int limit = 10)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getTopAlbums&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit={limit}";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get top albums ({error.Message})");
            }

            GetTopAlbumsResponse response = GetTopAlbumsResponse.FromJson(jsonString);
            IEnumerable<Album> albums = _mapper.Map<IEnumerable<Album>>(response.TopAlbums.Albums);
            return albums;
        }

        public async Task<IEnumerable<Artist>> GetTopArtistsAsync(string username, int limit = 10)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getTopArtists&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit={limit}";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get top artists ({error.Message})");
            }

            GetTopArtistsResponse response = GetTopArtistsResponse.FromJson(jsonString);
            IEnumerable<Artist> artists = _mapper.Map<IEnumerable<Artist>>(response.TopArtists.Artists);
            return artists;
        }

        public async Task<IEnumerable<Track>> GetTopTracksAsync(string username, int limit = 10)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getTopTracks&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit={limit}";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get top tracks ({error.Message})");
            }

            GetTopTracksResponse response = GetTopTracksResponse.FromJson(jsonString);
            IEnumerable<Track> tracks = _mapper.Map<IEnumerable<Track>>(response.TopTracks.Tracks);
            return tracks;
        }
    }
}