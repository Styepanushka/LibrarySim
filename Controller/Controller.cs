namespace LibrarySim.Controller;

internal class Controller : IController
{
    public UserBook.UserBook CreateNewUserBook(int bookId, int userId)
    {
        return new UserBook.UserBook(bookId, userId);
    }

    public UserBook.UserBook GetUserBook(int id)
    {
        return UserBook.UserBook.GetUserBook(id);
    }

    public void Read(int id)
    {
        UserBook.UserBook.GetUserBook(id).Read();
    }
}

