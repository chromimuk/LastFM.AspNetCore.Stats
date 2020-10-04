using LastFM.AspNetCore.Stats.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    internal interface IArtistRepository
    {
        Task<Artist> GetInfoAsync(string searchedArtist);
        Task<IEnumerable<Artist>> GetSimilarAsync(string searchedArtist, int limit = 10);
        Task<IEnumerable<Album>> GetTopAlbumsAsync(string searchedArtist, int limit = 10);
        Task<IEnumerable<Track>> GetTopTracksAsync(string searchedArtist, int limit = 10);
    }
}