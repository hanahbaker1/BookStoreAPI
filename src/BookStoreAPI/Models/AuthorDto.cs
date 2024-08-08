namespace BookStoreAPI.Models;

public class AuthorDto
{
    public AuthorDto(int id, string name, string biography, BookDto[] books)
    {
        Id = id;
        Name = name;
        Biography = biography;
        Books = books;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }
    public BookDto[] Books { get; set; }
}