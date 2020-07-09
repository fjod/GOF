namespace GOF.Structural.Facade
{
    public class PrinterFacade
    {
        private QuirkyPrinter printer;
        public PrinterFacade()
        {
            printer = new QuirkyPrinter();
        }

        public void PrintString(string s)
        {
            printer.PowerOn();
            printer.InsertPaper();
            printer.PrintSomething(s);
        }
    }
}