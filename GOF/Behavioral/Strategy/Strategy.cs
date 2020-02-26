using System;
using System.Collections.Generic;

namespace GOF.Behavioral.Strategy
{
    public class Strategy : IPatternTest
    {
        public void Implement()
        { 
            PrintProcessor processor =
             new PrintProcessor( s => Console.WriteLine($"delegate printed: {s}"));
            
            processor.PrintMessages(new List<IPrintMessage>{new ConcretePrinterA(),new ConcretePrinterB(),new ConcretePrinterC()});
        }

        public void Name()
        {
            Console.WriteLine("Strategy");
        }
    }
}