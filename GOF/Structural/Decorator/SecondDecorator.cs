using System;

namespace GOF.Structural.Decorator
{
    public class SecondDecorator : Decorator
    {
        public SecondDecorator(Printer printer) : base(printer)
        {
        }
        public override void Print()
        {
            Console.WriteLine("SecondDecorator starts work!");
            base.Print();
            Console.WriteLine("SecondDecorator finishes work!");
        }
    }
}