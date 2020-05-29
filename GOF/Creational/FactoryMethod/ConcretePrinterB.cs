using System;

namespace GOF.Creational.FactoryMethod
{
    public class ConcretePrinterB : PrinterBase
    {
        protected override IPrintText Printer()
        {
            return new PrinterB();
        }
    }

    public class PrinterB : IPrintText
    {
        public void Print(string t)
        {
            Console.WriteLine(t.ToUpper());
        }
    }
}