namespace LibrarySim.Book;

internal class Book : IBook
{
    protected static FileWork.FileWork _booksFile;
    protected static List<Book> _allBooks;
    public string _title;
    public string _author;

    public void AddToAllBooks()
    {
        _allBooks.Add(this);
    }

    static Book()
    {
        _booksFile = new FileWork.FileWork("C:\\Users\\Стёпа\\source\\repos\\LibrarySim\\Res\\book.txt");
        _allBooks = [];
        CashAllBooks();
    }

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        AddToAllBooks();
    }

    public Book(string raw)
    {
        string[] data = raw.Split('\t');
        _title = data[0];
        _author = data[1];
        AddToAllBooks();
    }

    public Book(int id)
    {
        string raw = _booksFile.ReadLine(id);
        string[] data = raw.Split('\t');
        _title = data[0];
        _author = data[1];
        AddToAllBooks();
    }

    public static Book GetBook(int id)
    {
        return _allBooks[id];
    }

    public static void CashAllBooks()
    {
        int c = 0;
        while (true)
        {
            try
            {
                new Book(c++);
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
        }
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
