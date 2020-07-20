using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories;

namespace LastFM.AspNetCore.Stats.Services
{
    public class LastFMServiceFactory
    {
        private readonly LastFMCredentials _credentials;
        private readonly LastFMRepositoryFactory _repositoryFactory;

        public LastFMServiceFactory(LastFMCredentials credentials)
        {
            _credentials = credentials;
            _repositoryFactory = new LastFMRepositoryFactory(_credentials);
        }

        public ILastFMUserService GetLastFMUserService()
        {
            return new LastFMUserService(_repositoryFactory.GetUserRepository());
        }
    }
}