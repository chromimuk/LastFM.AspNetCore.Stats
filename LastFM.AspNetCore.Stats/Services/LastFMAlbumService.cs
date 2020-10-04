using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services.Interfaces;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services
{
    internal class LastFMAlbumService : ILastFMAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public LastFMAlbumService(IAlbumRepository artistRepository)
        {
            _albumRepository = artistRepository;
        }

        public async Task<Album> GetInfoAsync(string artistName, string albumName)
        {
            return await _albumRepository.GetInfoAsync(artistName, albumName);
        }
    }
}