namespace LibrarySim.Controller;

using LibrarySim.UserBook;

internal class Controller : IController
{
    public void CreateNewUserBook(int bookId, int userId)
    {
        new UserBook(bookId, userId);
    }

    public UserBook GetUserBook(int id)
    {
        return UserBook.GetUserBook(id);
    }

    public void Read(int id)
    {
        UserBook.GetUserBook(id).Read();
    }
}

