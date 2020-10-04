using AutoMapper;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Utils;

namespace LastFM.AspNetCore.Stats.Repositories
{
    internal class LastFMRepositoryFactory
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

        public IArtistRepository GetArtistRepository()
        {
            return new ArtistRepository(_credentials, _mapper);
        }

        public IAlbumRepository GetAlbumRepository()
        {
            return new AlbumRepository(_credentials, _mapper);
        }
    }
}