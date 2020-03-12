using System;

namespace GOF.Behavioral.Mediator
{
    public class ConcreteCollegue2 : IPrintLine
    {
        public void Print(string line)
        {
            Console.WriteLine(line);
        }
    }
}