using LastFM.AspNetCore.Stats;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Exceptions;
using LastFM.AspNetCore.Stats.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Controller
{
    [TestClass]
    public class LastFMStatsControllerTests
    {
        private readonly LastFMStatsController _controller;

        public LastFMStatsControllerTests()
        {
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);
            _controller = new LastFMStatsController(credentials);
        }

        [TestMethod]
        public void LastFMStatsControllerTests_Init()
        {
            // Arrange
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);

            // Act
            LastFMStatsController controller = new LastFMStatsController(credentials);

            // Assert
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCredentialsException))]
        public void LastFMStatsControllerTests_Init_InvalidCredentials()
        {
            // Arrange
            LastFMCredentials credentials = null;

            // Act
            LastFMStatsController controller = new LastFMStatsController(credentials);

            // Assert
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetInfos()
        {
            // Arrange

            // Act
            LastFMUser user = await _controller.GetUserInfo("rj");

            // Assert
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.URL);
            Assert.IsNotNull(user.Image);
            Assert.IsNotNull(user.Playcount);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetLovedTracks()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _controller.GetLovedTracks("chromimuk");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetRecentTracks()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _controller.GetRecentTracks("chromimuk");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetTopAlbumsAsync()
        {
            // Arrange

            // Act
            List<Album> albums = (List<Album>)await _controller.GetTopAlbums("chromimuk");

            // Assert
            Assert.IsNotNull(albums.First().Artist);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetTopArtists()
        {
            // Arrange

            // Act
            List<Artist> albums = (List<Artist>)await _controller.GetTopArtists("chromimuk");

            // Assert
            Assert.IsNotNull(albums.First().Name);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetTopTracks()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _controller.GetTopTracks("chromimuk");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }
    }
}