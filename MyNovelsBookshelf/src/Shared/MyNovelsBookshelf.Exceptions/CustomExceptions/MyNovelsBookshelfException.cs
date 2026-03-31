namespace MyNovelsBookshelf.Exceptions.CustomExceptions
{
    public class MyNovelsBookshelfException : SystemException
    {
        public MyNovelsBookshelfException()
        {
        }

        public MyNovelsBookshelfException(string? message) : base(message)
        {
        }

        public MyNovelsBookshelfException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
