namespace BookStoreAPI.Models;

public class Book
{
    public Book(int id, string title, IReadOnlyList<Author> authors, Genre genre, DateTime publishedDate)
    {
        Id = id;
        Title = title;
        Authors = authors;
        Genre = genre;
        PublishedDate = publishedDate;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public IReadOnlyList<Author> Authors { get; set; }
    public Genre Genre { get; set; }
    public DateTime PublishedDate { get; set; }
}