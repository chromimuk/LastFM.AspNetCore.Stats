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
            CreateMap<ImageModel, Image>()
                .ForMember(x => x.Uri, m => m.MapFrom(o => o.Text));
            CreateMap<UserModel, LastFMUser>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.Last()));
            CreateMap<TrackModel, Track>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.Last()));
            CreateMap<AlbumModel, Album>()
                .ForMember(x => x.Image, m => m.MapFrom(o => o.Image.Last()));
        }
    }
}