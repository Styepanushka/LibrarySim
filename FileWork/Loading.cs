namespace LibrarySim.FileWork;

using LibrarySim.Book;
using LibrarySim.User;

internal class Loading
{
    private FileWork _bookFile;
    private FileWork _userFile;

    public Loading()
    {
        _bookFile = new FileWork(@"Res\book.txt");
        _userFile = new FileWork(@"Res\users.txt");
    }

    public Book LoadBook(int id)
    {
        string raw = _bookFile.ReadLine(id);
        string[] data = raw.Split('\t');

        return new Book(data[0], data[1]);
    }

    public void CashAllBooks()
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

    public User LoadUser(int id)
    {
        return new User(_userFile.ReadLine(id));
    }

    public void CashAllUsers()
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
