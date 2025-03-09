namespace LibrarySim.User;

internal class User : IUser
{
    private static List<User> _allUsers;

    private string _username;

    static User()
    {
        _allUsers = [];
    }

    public User(string username)
    {
        _username = username;
        _allUsers.Add(this);
    }

    public static User GetUser(int id)
    {
        return _allUsers[id];
    }

    public string GetUsername()
    {
        return _username;
    }
}

