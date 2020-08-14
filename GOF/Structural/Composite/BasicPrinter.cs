using System;

namespace GOF.Structural.Composite
{
    public class BasicPrinter : IExecutePrint
    {
        public void Print()
        {
            Console.WriteLine("Basic printer in action!");
        }
    }
}