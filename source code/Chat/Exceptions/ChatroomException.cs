namespace Chat.Exceptions
{
    public class ChatroomException : System.Exception
    {
        public ChatroomException(string message) : base(message)
        {
        }

        public ChatroomException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
