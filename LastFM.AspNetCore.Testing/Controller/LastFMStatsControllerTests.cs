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
            LastFMCredentialsTestingConfiguration testingConfiguration = new LastFMCredentialsTestingConfiguration();
            LastFMCredentials credentials = new LastFMCredentials(testingConfiguration.APIKey, testingConfiguration.SharedSecret);
            _controller = new LastFMStatsController(credentials);
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