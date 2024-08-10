using BookStoreAPI.Models;

namespace BookStoreAPI.Services;

public interface IAuthorService
{
    Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync();
    Task<AuthorDto> GetAuthorByIdAsync(int id);
    Task AddAuthorAsync(AuthorDto authorDto);
    Task UpdateAuthorAsync(AuthorDto authorDto);
    Task DeleteAuthorAsync(int id);
}