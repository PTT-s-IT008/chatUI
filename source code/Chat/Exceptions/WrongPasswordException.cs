namespace Chat.Exceptions
{
    public class WrongPasswordException : AuthentificationException
    {
        public WrongPasswordException(string message) : base(message)
        {
        }

        public WrongPasswordException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}