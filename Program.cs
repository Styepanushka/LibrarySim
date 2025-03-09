using LibrarySim.Controller;
using LibrarySim.FileWork;

class Programm
{
    public static void Main()
    {
        Loading.CashAllBooks();
        Loading.CashAllUsers();

        Console.WriteLine(Directory.GetCurrentDirectory());
        Controller controller = new Controller();
        while (true)
        {
            Console.WriteLine("Input command");
            string? command = Console.ReadLine();
            if (command == null)
                continue;
            if (command == "0")
            {
                Console.WriteLine("Input book id");
                int bookId = int.Parse(Console.ReadLine());
                Console.WriteLine("Input user id");
                int userId = int.Parse(Console.ReadLine());
                controller.CreateNewUserBook(bookId, userId);
                continue;
            }
            else if (command == "1")
            {
                Console.WriteLine("Input book id");
                int bookId = int.Parse(Console.ReadLine());
                controller.Read(bookId);
                continue;
            }
            else continue;
        }
    }
}