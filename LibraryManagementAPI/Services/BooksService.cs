namespace LibraryManagementAPI
{
    public static class BookService
    {
        public static Response AddBook(Book addBookRequest)
        {
            return BooksDBReader.AddBook(addBookRequest);
        }
        public static BooksResponse GetBooks(string filter = null)
        {
            if (filter == "available")
            {
                return BooksDBReader.GetAvailableBooks(true);
            }
            if (filter == "borrowed")
            {
                return BooksDBReader.GetAvailableBooks(false);
            }
            return null;
        }
    }
}
