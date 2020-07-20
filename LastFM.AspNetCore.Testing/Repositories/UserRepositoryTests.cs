using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Repositories
{
    [TestClass]
    public class UserRepositoryTests
    {
        private readonly UserRepository _repo;

        public UserRepositoryTests()
        {
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);
            IMapper mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<LastFMProfile>(); }));
            _repo = new UserRepository(credentials, mapper);
        }

        [TestMethod]
        public async Task UserRepositoryTests_GetInfosAsync()
        {
            // Arrange

            // Act
            LastFMUser user = await _repo.GetInfosAsync("chromimuk");

            // Assert
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.URL);
            Assert.IsNotNull(user.Image);
            Assert.IsNotNull(user.Playcount);
        }

        [TestMethod]
        public async Task UserRepositoryTests_GetLovedTracksAsync()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _repo.GetLovedTracksAsync("chromimuk");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }

        [TestMethod]
        public async Task UserRepositoryTests_GetRecentTracksAsync()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _repo.GetRecentTracksAsync("chromimuk");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }

        [TestMethod]
        public async Task UserRepositoryTests_GetTopArtistsAsync()
        {
            // Arrange

            // Act
            List<Artist> artists = (List<Artist>)await _repo.GetTopArtistsAsync("chromimuk");

            // Assert
            Assert.IsNotNull(artists.First().Name);
        }
    }
}