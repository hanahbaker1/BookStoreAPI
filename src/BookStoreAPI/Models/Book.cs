// Models/Book.cs

namespace BookStoreAPI.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int GenreId { get; set; }
}

// Models/Author.cs
public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Models/Genre.cs
public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// DTOs/BookDto.cs
public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public string GenreName { get; set; }
}