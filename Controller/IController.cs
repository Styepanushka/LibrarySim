namespace LibrarySim.Controller;

internal interface IController
{
    public void CreateNewUserBook(int bookId, int  userId);
    public UserBook.UserBook GetUserBook(int id);
    public void Read(int id);
}
