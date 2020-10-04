using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Responses;
using LastFM.AspNetCore.Stats.Responses.Album;
using LastFM.AspNetCore.Stats.Utils;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories
{
    internal class AlbumRepository : LastFMRepository, IAlbumRepository
    {
        public AlbumRepository(LastFMCredentials credentials, IMapper mapper) : base(credentials, mapper)
        {
        }

        public async Task<Album> GetInfoAsync(string artistName, string albumName)
        {
            if (artistName == null)
                return null;
            if (albumName == null)
                return null;

            string artistGetInfosURL = $"/2.0/?method=album.getInfo&artist={artistName}&album={albumName}&api_key={_lastFMCredentials.APIKey}&format=json";
            LastFMResponse lastFMResponse = Query(artistGetInfosURL).Result;
            string jsonString = await lastFMResponse.Message;

            if (!lastFMResponse.IsSuccessful)
            {
                GetErrorResponse error = GetErrorResponse.FromJson(jsonString);
                throw new DataAccessException($"Could not get user info ({error.Message})");
            }

            GetAlbumInfosResponse albumResponse = GetAlbumInfosResponse.FromJson(jsonString);

            Album album = _mapper.Map<Album>(albumResponse.Album);
            return album;
        }
    }
}