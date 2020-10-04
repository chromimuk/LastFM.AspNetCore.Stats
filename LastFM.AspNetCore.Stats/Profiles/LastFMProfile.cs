using AutoMapper;
using LastFM.AspNetCore.Stats.Entities;
using LastFM.AspNetCore.Stats.Models;
using System.Linq;

namespace LastFM.AspNetCore.Stats.Profiles
{
    internal class LastFMProfile : Profile
    {
        public LastFMProfile()
        {
            CreateMap<TagModel, Tag>();
            CreateMap<StatsModel, Statistics>();

            CreateMap<BioModel, Bio>()
                .ForMember(x => x.Link, m => m.MapFrom(o => o.Links.Link.Href));

            CreateMap<ArtistModel, Artist>()
                .ForMember(x => x.SimilarArtists, m => m.MapFrom(o => o.SimilarArtists.Artists))
                .ForMember(x => x.Tags, m => m.MapFrom(o => o.Tags.Tags))
                .ForMember(x => x.Statistics, m => m.MapFrom(o => o.Stats));

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