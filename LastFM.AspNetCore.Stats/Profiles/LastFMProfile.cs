using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Models;
using System.Linq;

namespace LastFM.AspNetCore.Stats.Profiles
{
    public class LastFMProfile : Profile
    {
        public LastFMProfile()
        {
            CreateMap<ArtistModel, Artist>();
            CreateMap<UserModel, LastFMUser>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.First()));
            CreateMap<ImageModel, Image>()
                .ForMember(x => x.Uri, m => m.MapFrom(o => o.Text));
            CreateMap<TrackModel, Track>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.First()));
            CreateMap<AlbumModel, Album>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.First()));
        }
    }
}