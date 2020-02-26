using System;

namespace GOF.Behavioral.Strategy
{ 
    class ConcretePrinterA : IPrintMessage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}