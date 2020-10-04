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
    public class LastFMArtistServiceTests
    {
        private readonly LastFMArtistService _service;

        public LastFMArtistServiceTests()
        {
            Mock<IArtistRepository> artistRepository = new Mock<IArtistRepository>();
            artistRepository.SetupAllProperties();

            // GetInfoAsync
            Artist artist = new Artist() { Name = "Juniore" };
            artistRepository.Setup(x => x.GetInfoAsync("Juniore")).Returns(Task.FromResult(artist));

            // GetSimilarArtistAsync
            IEnumerable<Artist> lovedTracks = new List<Artist>() { new Artist() { Name = "SimilarArtist" } };
            artistRepository.Setup(x => x.GetSimilarAsync("Juniore", 10)).Returns(Task.FromResult(lovedTracks));

            // GetTopAlbumsAsync
            IEnumerable<Album> topAlbums = new List<Album>() { new Album() { Name = "TopAlbum" } };
            artistRepository.Setup(x => x.GetTopAlbumsAsync("Juniore", 10)).Returns(Task.FromResult(topAlbums));

            // GetTopTracksAsync
            IEnumerable<Track> topTracks = new List<Track>() { new Track() { Name = "TopTrack" } };
            artistRepository.Setup(x => x.GetTopTracksAsync("Juniore", 10)).Returns(Task.FromResult(topTracks));

            _service = new LastFMArtistService(artistRepository.Object);
        }

        [TestMethod]
        public async Task LastFMArtistServiceTests_GetInfoAsync()
        {
            // Arrange

            // Act
            Artist user = await _service.GetInfoAsync("Juniore");

            // Assert
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public async Task LastFMArtistServiceTests_GetSimilarArtistAsync()
        {
            // Arrange

            // Act
            IEnumerable<Artist> artists = await _service.GetSimilarArtistsAsync("Juniore");

            // Assert
            Assert.IsNotNull(artists.Any());
        }

        [TestMethod]
        public async Task LastFMArtistServiceTests_GetTopAlbumsAsync()
        {
            // Arrange

            // Act
            IEnumerable<Album> albums = await _service.GetTopAlbumsAsync("Juniore");

            // Assert
            Assert.IsTrue(albums.Any());
        }

        [TestMethod]
        public async Task LastFMArtistServiceTests_GetTopTracksAsync()
        {
            // Arrange

            // Act
            IEnumerable<Track> tracks = await _service.GetTopTracksAsync("Juniore");

            // Assert
            Assert.IsNotNull(tracks.Any());
        }
    }
}