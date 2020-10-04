using LastFM.AspNetCore.Stats.Entities;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    internal interface IAlbumRepository
    {
        Task<Album> GetInfoAsync(string artistName, string albumName);
    }
}