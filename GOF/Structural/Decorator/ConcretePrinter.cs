using System;

namespace GOF.Structural.Decorator
{
    /// <summary>
    /// concrete classes do default implentations
    /// </summary>
    public class ConcretePrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("default printer working");
        }
    }
}