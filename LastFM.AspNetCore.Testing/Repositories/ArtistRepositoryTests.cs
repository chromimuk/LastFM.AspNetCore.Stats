using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories;
using LastFM.AspNetCore.Stats.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Repositories
{
    [TestClass]
    public class ArtistRepositoryTests
    {
        private readonly ArtistRepository _repo;

        public ArtistRepositoryTests()
        {
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);
            IMapper mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<LastFMProfile>(); }));
            _repo = new ArtistRepository(credentials, mapper);
        }

        [TestMethod]
        public async Task ArtistRepositoryTests_GetInfoAsync()
        {
            // Arrange

            // Act
            Artist artist = await _repo.GetInfoAsync("Juniore");

            // Assert
            Assert.IsNotNull(artist.Url);
            Assert.IsNotNull(artist.Name);
            Assert.IsNotNull(artist.Images);
            Assert.IsNotNull(artist.Statistics);
            Assert.IsNotNull(artist.SimilarArtists);
            Assert.IsNotNull(artist.Tags);
            Assert.IsNotNull(artist.Bio);
        }

        [TestMethod]
        public async Task ArtistRepositoryTests_GetSimilarAsync()
        {
            // Arrange

            // Act
            IEnumerable<Artist> artists = await _repo.GetSimilarAsync("Juniore");

            // Assert
            Assert.IsNotNull(artists);
            Assert.IsTrue(artists.Any());
        }

        [TestMethod]
        public async Task ArtistRepositoryTests_GetTopAlbumsAsync()
        {
            // Arrange

            // Act
            IEnumerable<Album> albums = await _repo.GetTopAlbumsAsync("Juniore");

            // Assert
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Any());
        }

        [TestMethod]
        public async Task ArtistRepositoryTests_GetTopTracksAsync()
        {
            // Arrange

            // Act
            IEnumerable<Track> tracks = await _repo.GetTopTracksAsync("Juniore");

            // Assert
            Assert.IsNotNull(tracks);
            Assert.IsTrue(tracks.Any());
        }
    }
}