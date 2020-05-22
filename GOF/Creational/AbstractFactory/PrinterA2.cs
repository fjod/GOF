using System;

namespace GOF.Creational.AbstractFactory
{
    public class PrinterA2 : IPrinterA
    {
        public void PrintText()
        {
            Console.WriteLine("Printer A2");
        }
    }
}