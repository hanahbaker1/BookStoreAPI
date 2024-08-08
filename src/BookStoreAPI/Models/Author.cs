namespace BookStoreAPI.Models;

public class Author
{
    public Author(int id, string name, string biography, IReadOnlyList<Book> books)
    {
        Id = id;
        Name = name;
        Biography = biography;
        Books = books;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }
    public IReadOnlyList<Book> Books { get; set; }
}