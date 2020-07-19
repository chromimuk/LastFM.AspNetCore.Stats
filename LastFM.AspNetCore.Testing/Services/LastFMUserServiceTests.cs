using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Services
{
    [TestClass]
    public class LastFMUserServiceTests
    {
        private readonly LastFMUserService _service;

        public LastFMUserServiceTests()
        {
            Mock<IUserRepository> userRepository = new Mock<IUserRepository>();
            userRepository.SetupAllProperties();

            // GetInfosAsync
            LastFMUser lastFMUser = new LastFMUser() { Name = "RJ", Image = "cat.jpg", Playcount = int.MaxValue, URL = "localhost" };
            userRepository.Setup(x => x.GetInfosAsync("rj")).Returns(Task.FromResult(lastFMUser));

            // GetLovedTracks
            IEnumerable<Track> tracks = new List<Track>() { new Track() { Artist = new Artist() { Name = "ArtistName" }, Name = "SongName" } };
            userRepository.Setup(x => x.GetLovedTracksAsync("rj")).Returns(Task.FromResult(tracks));

            _service = new LastFMUserService(userRepository.Object);
        }

        [TestMethod]
        public async Task LastFMUserServiceTests_GetInfosAsync()
        {
            // Arrange

            // Act
            LastFMUser user = await _service.GetInfosAsync("rj");

            // Assert
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.URL);
            Assert.IsNotNull(user.Image);
            Assert.IsNotNull(user.Playcount);
        }

        [TestMethod]
        public async Task LastFMUserServiceTests_GetLovedTracksAsync()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _service.GetLovedTracksAsync("rj");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }
    }
}