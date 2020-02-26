using System;

namespace GOF.Behavioral.Strategy
{ 
    class ConcretePrinterC : IPrintMessage
    {
        public void PrintMessage(string message)
        { 
            Console.WriteLine(message.ToUpper());
        }
    }
}