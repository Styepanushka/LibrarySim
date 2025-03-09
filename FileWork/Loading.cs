namespace LibrarySim.FileWork;

using LibrarySim.Book;
using LibrarySim.User;

internal static class Loading
{
    private static FileWork _bookFile;
    private static FileWork _userFile;

    static Loading()
    {
        _bookFile = new FileWork(@"Res\book.txt");
        _userFile = new FileWork(@"Res\users.txt");
    }

    public static Book LoadBook(int id)
    {
        string raw = _bookFile.ReadLine(id);
        string[] data = raw.Split('\t');

        return new Book(data[0], data[1]);
    }

    public static void CashAllBooks()
    {
        int c = 0;
        while (true)
        {
            try
            {
                LoadBook(c++);
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
        }
    }

    public static User LoadUser(int id)
    {
        return new User(_userFile.ReadLine(id));
    }

    public static void CashAllUsers()
    {
        int c = 0;
        while (true)
        {
            try
            {
                LoadUser(c++);
            }
            catch (IndexOutOfRangeException)
            {
                break;
            }
        }
    }
}
