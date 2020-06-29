namespace GOF.Creational.Builder
{
    public class Client
    {
        public string Message { get; private set; }
        public Client(string message)
        {
            Message = message;
        }

        public Client PrettierMessage()
        {
            Message = "Cool" + Message;
            return this;
        }
    }
}