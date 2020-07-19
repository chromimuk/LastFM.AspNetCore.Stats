using LastFM.AspNetCore.Stats.Entities;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<LastFMUser> GetInfosAsync(string username);
    }
}