using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories;
using LastFM.AspNetCore.Stats.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Repositories
{
    [TestClass]
    public class AlbumRepositoryTests
    {
        private readonly AlbumRepository _repo;

        public AlbumRepositoryTests()
        {
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);
            IMapper mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<LastFMProfile>(); }));
            _repo = new AlbumRepository(credentials, mapper);
        }

        [TestMethod]
        public async Task AlbumRepositoryTests_GetInfosAsync()
        {
            // Arrange

            // Act
            Album album = await _repo.GetInfoAsync("Juniore", "Un, Deux, Trois");

            // Assert
            Assert.IsNotNull(album.Url);
            Assert.IsNotNull(album.Name);
            Assert.IsNotNull(album.Tracks);
            Assert.IsNotNull(album.Tags);
        }
    }
}