namespace LibrarySim.FileWork;
internal class FileWork : IFileWork
{
    private string _allData;
    public string path;

    public FileWork(string path)
    {
        this.path = path;
        _allData = File.ReadAllText(path);
    }

    public string ReadAll()
    {
        _allData = File.ReadAllText(path);
        return _allData;
    }

    public string ReadLine(int id)
    {
        if(_allData.Length == 0)
            ReadAll();
        return _allData.Split('\n')[id];
    }

    public void WriteLine(string text, int id)
    {
        string[] new_data = _allData.Split('\n');
        new_data[id] = text;
        File.WriteAllLines(path, new_data);
    }
}
