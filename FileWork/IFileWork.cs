namespace LibrarySim.FileWork;

interface IFileWork
{
    public string ReadAll();
    public string ReadLine(int id);
    public void WriteLine(string text, int id);
}