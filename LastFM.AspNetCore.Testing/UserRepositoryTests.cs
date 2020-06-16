using AutoMapper;
using LastFM.AspNetCore.Stats;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LastFM.AspNetCore.Testing
{
    [TestClass]
    public class UserRepositoryTests
    {
        private readonly UserRepository _repo;

        public UserRepositoryTests()
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg => { cfg.AddProfile<UserProfile>(); }));
            _repo = new UserRepository(mapper);
        }
        
        [TestMethod]
        public async Task UserRepositoryTests_GetInfosAsync()
        {
            // Arrange 

            // Act
            LastFMUser user = await _repo.GetInfosAsync();

            // Assert
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.URL);
            Assert.IsNotNull(user.Image);
            Assert.IsNotNull(user.Playcount);
        }
    }
}
