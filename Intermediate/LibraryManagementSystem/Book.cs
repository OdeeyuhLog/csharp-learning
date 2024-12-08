namespace LibraryManagementSystem
{
    public class Book
    {
        public string BookName { get; }
        public bool IsBorrowed { get; set; }

        public Book(string bookName)
        {
            BookName = bookName;
            IsBorrowed = false;
        }


    }


}
