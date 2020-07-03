namespace GOF.Structural.Adapter
{
    public class AdapterForOldPrinter :IPrintAdapted
    {
        private OldPrinter _printer;

        public AdapterForOldPrinter(OldPrinter printer)
        {
            _printer = printer;
        }

        public void Print()
        {
            _printer.PrintString();
        }

        public void Print(PrintStringHolder s)
        {
            _printer.OldJammyPrintingDevice(s.String);
        }
    }
}