using LastFM.AspNetCore.Stats.Entities;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services
{
    public interface ILastFMUserService
    {
        Task<LastFMUser> GetInfosAsync(string username);
    }
}