namespace LibrarySim.Book;

internal class Book : IBook
{
    protected static List<Book> _allBooks;
    public string _title;
    public string _author;

    static Book()
    {
        _allBooks = [];
    }

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _allBooks.Add(this);
    }

    public static Book GetBook(int id)
    {
        return _allBooks[id];
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }
}
