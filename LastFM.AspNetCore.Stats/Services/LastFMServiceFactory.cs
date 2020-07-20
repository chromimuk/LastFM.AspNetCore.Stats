using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories;

namespace LastFM.AspNetCore.Stats.Services
{
    public class LastFMServiceFactory
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
    }
}