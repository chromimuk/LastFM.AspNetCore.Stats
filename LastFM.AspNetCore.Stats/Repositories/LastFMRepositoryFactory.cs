using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;

namespace LastFM.AspNetCore.Stats.Repositories
{
    public class LastFMRepositoryFactory
    {
        private LastFMCredentials _credentials;
        private IMapper mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<LastFMProfile>(); }));

        public LastFMRepositoryFactory(LastFMCredentials credentials)
        {
            _credentials = credentials;
        }

        public IUserRepository GetUserRepository()
        {
            return new UserRepository(_credentials, mapper);
        }
    }
}