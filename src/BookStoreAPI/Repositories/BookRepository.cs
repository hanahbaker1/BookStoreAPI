using BookStoreAPI.Models;
using Dapper;
using Npgsql;

namespace BookStoreAPI.Repositories;

public class BookRepository : IBookRepository
{
    private readonly string _connectionString;

    public BookRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        return await connection.QueryAsync<Book>("SELECT * FROM Books");
    }

    public async Task<Book> GetBookByIdAsync(int id)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        return (await connection.QuerySingleOrDefaultAsync<Book>("SELECT * FROM Books WHERE Id = @Id", new { Id = id }))!;
    }

    public async Task AddBookAsync(Book book)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("INSERT INTO Books (Title, AuthorId, GenreId) VALUES (@Title, @AuthorId, @GenreId)", book);
    }

    public async Task UpdateBookAsync(Book book)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("UPDATE Books SET Title = @Title, AuthorId = @AuthorId, GenreId = @GenreId WHERE Id = @Id", book);
    }

    public async Task DeleteBookAsync(int id)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync("DELETE FROM Books WHERE Id = @Id", new { Id = id });
    }
}