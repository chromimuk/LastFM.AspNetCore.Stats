using LastFM.AspNetCore.Stats.Entities;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    internal interface IArtistRepository
    {
        Task<Artist> GetInfosAsync(string searchedArtist);
    }
}