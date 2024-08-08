// Mappings/MappingProfile.cs

using AutoMapper;
using BookStoreAPI.Models;

namespace BookStoreAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.GenreId));
        }
    }
}