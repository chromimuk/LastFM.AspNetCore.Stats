using LastFM.AspNetCore.Stats.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<LastFMUser> GetInfosAsync(string username);

        Task<IEnumerable<Track>> GetLovedTracksAsync(string username);

        Task<IEnumerable<Track>> GetRecentTracksAsync(string username);

        Task<IEnumerable<Album>> GetTopAlbumsAsync(string username);

        Task<IEnumerable<Artist>> GetTopArtistsAsync(string username);
    }
}