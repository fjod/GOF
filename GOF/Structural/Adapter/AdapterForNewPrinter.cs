using System;

namespace GOF.Structural.Adapter
{
    public class AdapterForNewPrinter : IPrintAdapted
    {
        private NewClassyPrinter _printer;

        public AdapterForNewPrinter(NewClassyPrinter printer)
        {
            _printer = printer;
        }

        public void Print()
        { 
            _printer.ItCanPrintToo();
        }

        public void Print(PrintStringHolder s)
        {
            _printer.Prints500PagesPerSecond(s.String);
        }
    }
}