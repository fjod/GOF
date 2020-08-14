using System;
using System.Collections.Generic;

namespace GOF.Structural.Composite
{
    //the idea is to use tree-like structure
    //to have leaf and composite
    //both of them derive from same object
    //composite can contain leafs and other composites
    //so client does not need to know about all of this
    //it just uses base-class method while composite can do some job on leaves
    public class Composite : IPatternTest
    {
        public void Implement()
        {
            var basic = new BasicPrinter();
            var nested = new NestedPrinter();
            var VirtualPrinter = new VirtualPrinter();
            CompositePrinter cp = new CompositePrinter();
            cp.Add(nested);
            cp.Add(VirtualPrinter);
            
            Client cc = new Client(new List<IExecutePrint>{basic,cp});
            
        }

        public void Name()
        {
            Console.WriteLine("Composite pattern");
        }
    }
}