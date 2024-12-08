namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Library System");
                Console.WriteLine("--------------");
                Console.WriteLine("1 - Add Book");
                Console.WriteLine("2 - Search Book");
                Console.WriteLine("3 - Borrow Book");
                Console.WriteLine("4 - Return Book");
                Console.WriteLine("5 - Quit");

                if (!int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 and 5");
                    continue;
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.Write("Enter the name of your book: ");
                        string addedBookName = Console.ReadLine();
                        library.AddBook(addedBookName);

                        break;
                    case 2:
                        Console.Write("Enter the book you want to search: ");
                        string searchedBookName = Console.ReadLine();
                        library.SearchBook(searchedBookName);
                        break;
                    case 3:
                        Console.Write("Enter the book you want to borrow: ");
                        string borrowBookName = Console.ReadLine();
                        library.BorrowBook(borrowBookName);
                        break;
                    case 4:
                        Console.Write("Enter the book you want to return: ");
                        string returnedBookName = Console.ReadLine();
                        library.ReturnBook(returnedBookName);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a valid menu choice. ");
                        break;
                }
            }
        }
    }
}
