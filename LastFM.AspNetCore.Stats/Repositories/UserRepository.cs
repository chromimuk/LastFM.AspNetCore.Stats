using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Responses;
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

            GetInfosResponse getInfosResponse = GetInfosResponse.FromJson(jsonString);
            LastFMUser user = _mapper.Map<LastFMUser>(getInfosResponse.User);
            return user;
        }
    }
}