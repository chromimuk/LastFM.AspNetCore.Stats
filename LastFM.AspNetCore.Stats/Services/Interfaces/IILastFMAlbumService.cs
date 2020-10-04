using LastFM.AspNetCore.Stats.Entities;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Services.Interfaces
{
    internal interface ILastFMAlbumService
    {
        Task<Album> GetInfoAsync(string artistName, string albumName);
    }
}