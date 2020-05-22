using System;

namespace GOF.Creational.AbstractFactory
{
    public class PrinterB : IPrinterB
    {
        public void PrintText()
        {
            Console.WriteLine("Print a");
        }
    }
}