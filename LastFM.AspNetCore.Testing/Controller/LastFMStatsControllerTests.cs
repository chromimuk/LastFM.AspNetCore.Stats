using LastFM.AspNetCore.Stats;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing.Controller
{
    [TestClass]
    public class LastFMStatsControllerTests
    {
        private readonly LastFMStatsController _controller;

        public LastFMStatsControllerTests()
        {
            LastFMCredentials credentials = new LastFMCredentials("abc", "abc");
            LastFMUser lastFMUser = new LastFMUser() { Name = "RJ", Image = "cat.jpg", Playcount = int.MaxValue, URL = "localhost" };

            Mock<ILastFMUserService> userService = new Mock<ILastFMUserService>();
            userService.SetupAllProperties();
            userService.Setup(x => x.GetInfosAsync("rj")).Returns(Task.FromResult(lastFMUser));

            _controller = new LastFMStatsController(credentials, userService.Object);
        }

        [TestMethod]
        public async Task LastFMStatsControllerTests_GetInfosAsync()
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
    }
}