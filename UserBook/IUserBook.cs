namespace LibrarySim.UserBook;

internal interface IUserBook
{
    public Book.Book GetBook();
    public User.User GetUser();

    public void Read();
}

