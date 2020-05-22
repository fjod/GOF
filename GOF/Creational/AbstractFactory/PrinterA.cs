using System;

namespace GOF.Creational.AbstractFactory
{
    public class PrinterA : IPrinterA
    {
        public void PrintText()
        {
            Console.WriteLine("Print a");
        }
    }
}