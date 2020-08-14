using System;

namespace GOF.Structural.Composite
{
    public class VirtualPrinter : IExecutePrint
    {
        public void Print()
        {
            Console.WriteLine("Virtual print");
        }
    }
}