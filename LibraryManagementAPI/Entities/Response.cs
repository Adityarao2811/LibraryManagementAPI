namespace LibraryManagementAPI
{
    public class Response
    {
        public string Message;
        public Status Status;
    }

    public enum Status
    {
        Failure,
        Success
    }
}
