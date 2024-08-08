namespace BookStoreAPI.Models;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Book[] Books { get; set; }
}