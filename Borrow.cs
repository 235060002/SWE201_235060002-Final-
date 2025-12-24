public class Borrow
{
    public Book BorrowedBook { get; set; }
    public Member Member { get; set; }
    public int BorrowDays { get; set; }

    public Borrow(Book book, Member member, int borrowDays)
    {
        BorrowedBook = book;
        Member = member;
        BorrowDays = borrowDays;
        book.BorrowBook();
    }

    public void ShowBorrowInfo()
    {
        Console.WriteLine($"Member: {Member.FullName}");
        Console.WriteLine($"Book: {BorrowedBook.Title}");
        Console.WriteLine($"Author: {BorrowedBook.Author}");
        Console.WriteLine($"Borrow Days: {BorrowDays}");
        Console.WriteLine($"Book Available: {BorrowedBook.IsAvailable}");
    }
}
