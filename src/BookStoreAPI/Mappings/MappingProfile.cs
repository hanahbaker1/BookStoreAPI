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
                .ForMember(dest => dest.AuthorNames, opt => opt.MapFrom(src => src.Authors.Select(x =>x.Name)))
                .ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.Genre.Name));
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Books,
                    opt => opt.MapFrom(src => src.Books.Select(x => new BookDto(x.Id, x.Title,
                        x.Authors.Select(x => x.Name).ToArray(), x.Genre.Name, x.Price, x.PublishedDate))));
        }
    }
}