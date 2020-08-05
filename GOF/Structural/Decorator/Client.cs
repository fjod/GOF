namespace GOF.Structural.Decorator
{
    public class Client
    {
        public void ClientWork(Printer printer)
        {
            printer.Print();
        }
    }
}