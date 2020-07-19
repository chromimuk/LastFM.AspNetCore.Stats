using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Models;
using System.Linq;

namespace LastFM.AspNetCore.Stats.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, LastFMUser>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.First().Text.ToString()));
        }
    }
}