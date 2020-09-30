using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Responses;
using LastFM.AspNetCore.Stats.Utils;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    internal interface IArtistRepository
    {
    }

    public class ArtistRepository : LastFMRepository, IArtistRepository
    {
        public ArtistRepository(LastFMCredentials credentials, IMapper mapper) : base(credentials, mapper)
        {
        }

        public async Task<Artist> GetInfosAsync(string searchedArtist)
        {
            if (searchedArtist == null)
                return null;

            string userGetUserInfoURL = $"/2.0/?method=artist.getinfo&artist={searchedArtist}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(userGetUserInfoURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetArtistResponse artistResponse = GetArtistResponse.FromJson(jsonString);

            Artist artist = _mapper.Map<Artist>(artistResponse.Artist);
            return artist;
        }
    }
}