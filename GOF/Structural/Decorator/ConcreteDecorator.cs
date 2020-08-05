using System;

namespace GOF.Structural.Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Printer printer) : base(printer)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Concrete decorator starts work!");
            base.Print();
            Console.WriteLine("Concrete decorator finishes work!");
        }
    }
}