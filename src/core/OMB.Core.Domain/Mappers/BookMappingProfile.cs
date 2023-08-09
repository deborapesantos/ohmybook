using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OMB.Adapter.Repository.Entites;

namespace OMB.Core.Domain.Mappers
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<UserBookRegistryEntity, Book>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Edicao.Titulo))
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Edicao.Autor));

            CreateMap<UserBookRegistryEntity, UserBookshelf>()
                .ForMember(dest => dest.Favorite, opt => opt.MapFrom(src => int.Parse(src.Favorito) > 0))
                .ForMember(dest => dest.HaveReaded, opt => opt.MapFrom(src => int.Parse(src.Tipo) == 1))
                .ForMember(dest => dest.Reading, opt => opt.MapFrom(src => int.Parse(src.Tipo) == 2))
                .ForMember(dest => dest.WantToRead, opt => opt.MapFrom(src => int.Parse(src.Tipo) == 3))
                .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src));

        }
    }
}