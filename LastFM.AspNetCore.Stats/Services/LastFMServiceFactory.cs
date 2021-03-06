﻿using LastFM.AspNetCore.Stats.Repositories;
using LastFM.AspNetCore.Stats.Services.Interfaces;
using LastFM.AspNetCore.Stats.Utils;

namespace LastFM.AspNetCore.Stats.Services
{
    internal class LastFMServiceFactory
    {
        private readonly LastFMRepositoryFactory _repositoryFactory;

        public LastFMServiceFactory(LastFMCredentials credentials)
        {
            _repositoryFactory = new LastFMRepositoryFactory(credentials);
        }

        public ILastFMUserService GetLastFMUserService()
        {
            return new LastFMUserService(_repositoryFactory.GetUserRepository());
        }

        public ILastFMArtistService GetLastFMArtistService()
        {
            return new LastFMArtistService(_repositoryFactory.GetArtistRepository());
        }

        public ILastFMAlbumService GetLastFMAlbumService()
        {
            return new LastFMAlbumService(_repositoryFactory.GetAlbumRepository());
        }
    }
}