using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Responses;
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
            Task<string> data = Query(userGetUserInfoURL);
            string jsonString = await data;

            GetInfosResponse tracks = GetInfosResponse.FromJson(jsonString);

            LastFMUser user = _mapper.Map<LastFMUser>(tracks.User);
            return user;
        }

        public async Task<IEnumerable<Track>> GetLovedTracksAsync(string username)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getlovedtracks&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit=10";
            Task<string> data = Query(userGetUserInfoURL);
            string jsonString = await data;

            GetLovedTracksResponse response = GetLovedTracksResponse.FromJson(jsonString);

            IEnumerable<Track> tracks = _mapper.Map<IEnumerable<Track>>(response.LovedTracks.Tracks);
            return tracks;
        }

        public async Task<IEnumerable<Track>> GetRecentTracksAsync(string username)
        {
            if (username == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=user.getrecenttracks&user={username}&api_key={_lastFMCredentials.APIKey}&format=json&limit=1&extended=1";
            Task<string> data = Query(userGetUserInfoURL);
            string jsonString = await data;

            GetRecentTracksResponse response = GetRecentTracksResponse.FromJson(jsonString);

            IEnumerable<Track> tracks = _mapper.Map<IEnumerable<Track>>(response.RecentTracks.Tracks);
            return tracks;
        }
    }

}



