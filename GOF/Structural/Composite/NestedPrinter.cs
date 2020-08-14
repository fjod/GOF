using System;

namespace GOF.Structural.Composite
{
    public class NestedPrinter : IExecutePrint
    {
        public void Print()
        {
            Console.WriteLine("Nested printer was here");
        }
    }
}