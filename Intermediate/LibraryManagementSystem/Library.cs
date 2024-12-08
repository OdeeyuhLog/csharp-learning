namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(string bookName)
        {
            _books.Add(new Book(bookName)
                );
        }

        public void SearchBook(string bookName)
        {
            Book foundBook = _books.Find(b => string.Equals(b.BookName, bookName, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                Console.WriteLine($"Yes, the book {bookName} is available at the library");
            }
            else
            {
                Console.WriteLine($"Sorry, the book {bookName} is not available at the libraray.");
            }
        }

        public void BorrowBook(string bookName)
        {
            Book foundBook = _books.Find(b => string.Equals(b.BookName, bookName, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                if (!foundBook.IsBorrowed)
                {
                    foundBook.IsBorrowed = true;
                    Console.WriteLine($"You borrowed the book {bookName}.");
                }
                else
                {
                    Console.WriteLine("Sorry, this book had been already borrowed");
                }
            }
            else
            {
                Console.WriteLine($"Sorry, the book {bookName} is not available in the library");
            }
        }

        public void ReturnBook(string bookName)
        {
            Book foundBook = _books.Find(b => string.Equals(b.BookName, bookName, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                if (foundBook.IsBorrowed)
                {
                    foundBook.IsBorrowed = false;
                    Console.WriteLine($"You returned the book {bookName}.");
                }
                else
                {
                    Console.WriteLine("Sorry, this book is not borrowed. No action needed");
                }
            }
            else
            {
                _books.Add(new Book(bookName));
                Console.WriteLine($"Sorry, the book {bookName} is not available in the library but will be added to the library");
            }
        }
    }

}
