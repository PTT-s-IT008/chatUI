namespace Chat.Exceptions
{
    public class AuthentificationException : System.Exception
    {
        public AuthentificationException(string message) : base(message)
        {
        }

        public AuthentificationException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
