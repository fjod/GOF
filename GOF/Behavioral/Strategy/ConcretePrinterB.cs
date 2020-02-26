using System;

namespace GOF.Behavioral.Strategy
{ 
    class ConcretePrinterB: IPrintMessage
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }
}