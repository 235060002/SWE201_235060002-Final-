public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        IsAvailable = false;
    }

    public void ReturnBook()
    {
        IsAvailable = true;
    }
}
