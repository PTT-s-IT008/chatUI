namespace Chat.Exceptions
{
    public class ChatroomUnknownException : ChatroomException
    {
        public ChatroomUnknownException(string message) : base(message)
        {
        }

        public ChatroomUnknownException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
