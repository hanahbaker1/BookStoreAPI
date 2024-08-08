using BookStoreAPI.Models;
using Dapper;
using Npgsql;

namespace BookStoreAPI.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly string _connectionString;

    public AuthorRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        return await connection.QueryAsync<Author>("SELECT * FROM Authors");
    }

    public async Task<Author> GetAuthorByIdAsync(int id)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        return (await connection.QuerySingleOrDefaultAsync<Author>("SELECT * FROM Authors WHERE Id = @Id", new { Id = id }))!;
    }

    public async Task AddAuthorAsync(Author author)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("INSERT INTO Authors (Name) VALUES (@Name)", author);
    }

    public async Task UpdateAuthorAsync(Author author)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("UPDATE Authors SET Name = @Name WHERE Id = @Id", author);
    }

    public async Task DeleteAuthorAsync(int id)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("DELETE FROM Authors WHERE Id = @Id", new { Id = id });
    }
}