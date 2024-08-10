namespace BookStoreAPI.Models;

public class Book
{
    public Book(int id, string title, IReadOnlyList<Author> authors, Genre genre, decimal price, DateTime publishedDate)
    {
        Id = id;
        Title = title;
        Authors = authors;
        Genre = genre;
        Price = price;
        PublishedDate = publishedDate;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public IReadOnlyList<Author> Authors { get; set; }
    public Genre Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishedDate { get; set; }
}