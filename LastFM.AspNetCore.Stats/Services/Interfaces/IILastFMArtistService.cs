using LastFM.AspNetCore.Stats.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services.Interfaces
{
    internal interface ILastFMArtistService

    {
        Task<Artist> GetInfosAsync(string searchedArtist);
        Task<IEnumerable<Artist>> GetSimilarArtistsAsync(string searchedArtist, int limit = 10);
        Task<IEnumerable<Album>> GetTopAlbumsAsync(string searchedArtist, int limit = 10);
        Task<IEnumerable<Track>> GetTopTracksAsync(string searchedArtist, int limit = 10);
    }
}