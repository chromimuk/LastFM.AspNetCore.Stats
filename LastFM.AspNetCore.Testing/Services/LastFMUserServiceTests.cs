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

            // GetLovedTracksAsync
            IEnumerable<Track> lovedTracks = new List<Track>() { new Track() { Artist = new Artist() { Name = "LovedArtistName" }, Name = "LovedSongName" } };
            userRepository.Setup(x => x.GetLovedTracksAsync("rj")).Returns(Task.FromResult(lovedTracks));

            // GetRecentTracksAsync
            IEnumerable<Track> recentTracks = new List<Track>() { new Track() { Artist = new Artist() { Name = "RecentArtist" }, Name = "RecentSongName" } };
            userRepository.Setup(x => x.GetRecentTracksAsync("rj")).Returns(Task.FromResult(recentTracks));

            // GetTopAlbumsAsync
            IEnumerable<Album> topAlbums = new List<Album>() { new Album() { Name = "TopAlbumName" } };
            userRepository.Setup(x => x.GetTopAlbumsAsync("rj")).Returns(Task.FromResult(topAlbums));

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

        [TestMethod]
        public async Task LastFMUserServiceTests_GetRecentTracksAsync()
        {
            // Arrange

            // Act
            List<Track> tracks = (List<Track>)await _service.GetRecentTracksAsync("rj");

            // Assert
            Assert.IsNotNull(tracks.First().Artist);
            Assert.IsNotNull(tracks.First().Name);
        }

        [TestMethod]
        public async Task LastFMUserServiceTests_GetTopAlbumsAsync()
        {
            // Arrange

            // Act
            List<Album> albums = (List<Album>)await _service.GetTopAlbumsAsync("rj");

            // Assert
            Assert.IsNotNull(albums.First().Name);
        }
    }
}