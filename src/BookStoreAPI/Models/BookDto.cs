namespace BookStoreAPI.Models;

public class BookDto
{
    public BookDto(int id, string title, string[] authorNames, string genreName, decimal price, DateTime publishedDate)
    {
        Id = id;
        Title = title;
        AuthorNames = authorNames;
        GenreName = genreName;
        Price = price;
        PublishedDate = publishedDate;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string[] AuthorNames { get; set; }
    public string GenreName { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishedDate { get; set; }
}