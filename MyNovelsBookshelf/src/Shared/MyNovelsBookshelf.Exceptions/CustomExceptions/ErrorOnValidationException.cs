namespace MyNovelsBookshelf.Exceptions.CustomExceptions
{
    public class ErrorOnValidationException(IList<string> errorMessages) : MyNovelsBookshelfException
    {
        public IList<string> ErrorMessages { get; set; } = errorMessages;
    }
}
