namespace Chat.Exceptions
{
    public class RegisterException : System.Exception
    {
        public RegisterException(string message) : base(message)
        {
        }

        public RegisterException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}