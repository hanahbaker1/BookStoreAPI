using AutoMapper;
using BookStoreAPI.Models;
using BookStoreAPI.Repositories;

namespace BookStoreAPI.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IMapper _mapper;

    public Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<AuthorDto> GetAuthorByIdAsync(int id)
    {
        var author = await _authorRepository.GetAuthorByIdAsync(id);
        return _mapper.Map<AuthorDto>(author);
    }

    public Task AddAuthorAsync(AuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        return _authorRepository.AddAuthorAsync(author);
    }

    public Task UpdateAuthorAsync(AuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        return _authorRepository.UpdateAuthorAsync(author);
    }

    public Task DeleteAuthorAsync(int id)
    {
        await _authorRepository.DeleteAuthorAsync(id);
    }
}