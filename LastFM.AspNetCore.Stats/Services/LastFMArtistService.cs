using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services
{
    internal class LastFMArtistService : ILastFMArtistService
    {
        private readonly IArtistRepository _artistRepository;

        public LastFMArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public async Task<Artist> GetInfosAsync(string username)
        {
            return await _artistRepository.GetInfosAsync(username);
        }

        public async Task<IEnumerable<Artist>> GetSimilarArtistsAsync(string searchedArtist, int limit = 10)
        {
            return await _artistRepository.GetSimilarAsync(searchedArtist, limit);
        }

        public async Task<IEnumerable<Album>> GetTopAlbumsAsync(string searchedArtist, int limit = 10)
        {
            return await _artistRepository.GetTopAlbumsAsync(searchedArtist, limit);
        }

        public async Task<IEnumerable<Track>> GetTopTracksAsync(string searchedArtist, int limit = 10)
        {
            return await _artistRepository.GetTopTracksAsync(searchedArtist, limit);
        }
    }
}