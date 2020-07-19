using AutoMapper;
using LastFM.AspNetCore.Stats;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using LastFM.AspNetCore.Stats.Repositories;
using LastFM.AspNetCore.Stats.Repositories.Interfaces;
using LastFM.AspNetCore.Stats.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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

            LastFMUser lastFMUser = new LastFMUser() { Name = "RJ", Image = "cat.jpg", Playcount = int.MaxValue, URL = "localhost" };
            userRepository.Setup(x => x.GetInfosAsync("rj")).Returns(Task.FromResult(lastFMUser));

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
    }
}
