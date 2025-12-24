class Program
{
    static void Main(string[] args)
    {
        Book book = new Book(1, "Clean Code", "Robert C. Martin");
        Member member = new Member(101, "Aday Akyüz");

        Borrow borrow = new Borrow(book, member, 14);
        borrow.ShowBorrowInfo();

        Console.ReadLine();
    }
}
