using System.Collections.Generic;

namespace GOF.Structural.Composite
{
    public class Client
    {
        public Client(List<IExecutePrint> printers)
        {
            foreach (var executePrint in printers)
            {
                executePrint.Print();
            }
        }
    }
}