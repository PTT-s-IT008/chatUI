namespace Chat.Exceptions
{
    public class SessionAlreadyExistsException : AuthentificationException
    {
        public SessionAlreadyExistsException(string message) : base(message)
        {
        }

        public SessionAlreadyExistsException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
