namespace GOF.Structural.Proxy
{
    public class Client
    {
        public void UsePrinter(IPrint print)
        {
            print.Print();
        }
    }
}