namespace LibrarySim.UserBook;

using LibrarySim.Book;
using LibrarySim.User;
internal class UserBook : IUserBook
{
    private static List<UserBook> _allUserBook;

    private int _bookId;
    private int _userId;

    static UserBook()
    {
        _allUserBook = [];
    }

    public static UserBook GetUserBook(int id)
    {
        return _allUserBook[id];
    }

    public UserBook(int bookId, int userId)
    {
        if (bookId < 0 || userId < 0)
            throw new ArgumentOutOfRangeException("Book ID and user ID must be positive");
        _bookId = bookId;
        _userId = userId;
        _allUserBook.Add(this);
    }
    public Book GetBook()
    {
        return Book.GetBook(_bookId);
    }

    public User GetUser()
    {
        return User.GetUser(_userId);
    }

    public void Read()
    {
        Console.WriteLine(
            User.GetUser(_userId).GetUsername()
            +
            " is reading "
            +
            Book.GetBook(_bookId).GetTitle()
            +
            " written by "
            +
            Book.GetBook(_bookId).GetAuthor()
            );
    }
}

