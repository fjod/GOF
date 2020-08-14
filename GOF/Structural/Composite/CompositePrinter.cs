using System.Collections.Generic;

namespace GOF.Structural.Composite
{
    
    public class CompositePrinter : IExecutePrint
    {
        List<IExecutePrint> printers = new List<IExecutePrint>();
        public void Add(IExecutePrint printer)
        {
            printers.Add(printer);
        }

        //remove, get etc..
        public void Print()
        {
            foreach (var executePrint in printers)
            {
                executePrint.Print();
            }
        }
    }
}