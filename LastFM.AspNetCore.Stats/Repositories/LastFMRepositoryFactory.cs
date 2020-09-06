using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;

namespace LastFM.AspNetCore.Stats.Repositories
{
    public class LastFMRepositoryFactory
    {
        private readonly LastFMCredentials _credentials;
        private readonly IMapper _mapper;

        public LastFMRepositoryFactory(LastFMCredentials credentials)
        {
            _credentials = credentials;
            _mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<LastFMProfile>(); }));
        }

        public IUserRepository GetUserRepository()
        {
            return new UserRepository(_credentials, _mapper);
        }
    }
}