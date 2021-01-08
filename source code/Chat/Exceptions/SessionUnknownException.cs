namespace Chat.Exceptions
{
    public class SessionUnknownException : AuthentificationException
    {
        public SessionUnknownException(string message) : base(message)
        {
        }

        public SessionUnknownException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
