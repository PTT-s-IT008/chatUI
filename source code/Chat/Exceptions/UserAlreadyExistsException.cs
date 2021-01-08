namespace Chat.Exceptions
{
    public class UserAlreadyExistsException : AuthentificationException
    {
        public UserAlreadyExistsException(string message) : base(message)
        {
        }

        public UserAlreadyExistsException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
