namespace LibrarySim.User;

internal class User : IUser
{
    private static FileWork.FileWork _usersFile;
    private static List<User> _allUsers;

    private string _username;

    static User()
    {
        _usersFile = new FileWork.FileWork("C:\\Users\\Стёпа\\source\\repos\\LibrarySim\\Res\\users.txt");
        _allUsers = [];
        CashAllUsers();
    }

    public User(string username)
    {
        _username = username;
        AddToAllUsers();
    }

    public User(int id)
    {
        _username = _usersFile.ReadLine(id);
        AddToAllUsers();
    }

    public void AddToAllUsers()
    {
        _allUsers.Add(this);
    }

    public static User GetUser(int id)
    {
        return _allUsers[id];
    }

    public static void CashAllUsers()
    {
        int c = 0;
        while(true)
        {
            try
            {
                new User(c++);
            }
            catch(IndexOutOfRangeException)
            {
            break;
            }
        }
    }

    public string GetUsername()
    {
        return _username;
    }
}

