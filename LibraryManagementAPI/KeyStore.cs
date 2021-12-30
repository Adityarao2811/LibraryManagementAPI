namespace LibraryManagementAPI
{
    public static class KeyStore
    {
        public static string AuthorDBFilePath = @"C:\Users\pc\source\repos\LibrarySystemAPI\LibrarySystemAPI\Database\Authors.txt";
        public static string BooksDBFilePath = @"C:\Users\pc\source\repos\LibrarySystemAPI\LibrarySystemAPI\Database\AuthorBooks.txt";

        public static string AuthorAlreadyExistsMessage = "Author already exists";

        public static string AuthorDoesNotExistMessage = "Author does not exist";

        public static string BookIsAlreadyBorrowed = "Book is already Borrowed";

        public static string BookIsNotBorrowed = "Book is not Borrowed";
    }
}
