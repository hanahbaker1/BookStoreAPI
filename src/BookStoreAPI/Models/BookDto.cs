namespace BookStoreAPI.Models;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string[] AuthorNames { get; set; }
    public string GenreName { get; set; }
}