using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GOF.Creational.FactoryMethod
{
    public class Client : IPatternTest
    {
        //it's the same as template method
        // the difference is it creates something
        //while template method calls something
        public void Implement()
        {
            IList<PrinterBase> list = new Collection<PrinterBase>{new ConcretePrinterA(), new ConcretePrinterB()};
            foreach (var printerBase in list)
            {
                printerBase.Print();
            }
        }

        public void Name()
        {
            Console.WriteLine("Factory method");
        }
    }
}