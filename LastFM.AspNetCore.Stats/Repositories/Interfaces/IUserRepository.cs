﻿using LastFM.AspNetCore.Stats.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Stats.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        Task<LastFMUser> GetInfoAsync(string username);

        Task<IEnumerable<Track>> GetLovedTracksAsync(string username, int limit = 10);

        Task<IEnumerable<Track>> GetRecentTracksAsync(string username, int limit = 10);

        Task<IEnumerable<Album>> GetTopAlbumsAsync(string username, int limit = 10);

        Task<IEnumerable<Artist>> GetTopArtistsAsync(string username, int limit = 10);

        Task<IEnumerable<Track>> GetTopTracksAsync(string username, int limit = 10);
    }
}