using AutoMapper;
using BookStoreAPI.Models;
using BookStoreAPI.Repositories;

namespace BookStoreAPI.Services;

public interface IAuthorService
{
    Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync();
    Task<AuthorDto> GetAuthorByIdAsync(int id);
    Task AddAuthorAsync(AuthorDto authorDto);
    Task UpdateAuthorAsync(AuthorDto authorDto);
    Task DeleteAuthorAsync(int id);
}

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _bookRepository;
    private readonly IMapper _mapper;

    public Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AuthorDto> GetAuthorByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAuthorAsync(AuthorDto authorDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAuthorAsync(AuthorDto authorDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAuthorAsync(int id)
    {
        throw new NotImplementedException();
    }
}