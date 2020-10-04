using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Services
{
    [TestClass]
    public class LastFMAlbumServiceTests
    {
        private readonly LastFMAlbumService _service;

        public LastFMAlbumServiceTests()
        {
            Mock<IAlbumRepository> albumRepository = new Mock<IAlbumRepository>();
            albumRepository.SetupAllProperties();

            // GetInfosAsync
            Album album = new Album() { Name = "Un, deux, trois", Artist = new Artist() { Name = "Juniore" } };
            albumRepository.Setup(x => x.GetInfoAsync("Juniore", "Un, deux, trois")).Returns(Task.FromResult(album));

            _service = new LastFMAlbumService(albumRepository.Object);
        }

        [TestMethod]
        public async Task LastFMAlbumServiceTests_GetInfoAsync()
        {
            // Arrange

            // Act
            Album user = await _service.GetInfoAsync("Juniore", "Un, deux, trois");

            // Assert
            Assert.IsNotNull(user.Name);
        }
    }
}