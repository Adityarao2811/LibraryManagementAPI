namespace LibraryManagementAPI
{
    public static class AuthorService
    {
        public static Response AddAuthor(string authorName)
        {
            return AuthorDBReader.AddAuthor(authorName);
        }
    }
}
