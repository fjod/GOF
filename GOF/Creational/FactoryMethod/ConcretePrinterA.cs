using System;

namespace GOF.Creational.FactoryMethod
{
    public class ConcretePrinterA : PrinterBase
    {
        protected override IPrintText Printer()
        {
           return new PrinterA();
        }
    }

    public class PrinterA : IPrintText
    {
        public void Print(string t)
        {
            Console.WriteLine(t);
        }
    }
}