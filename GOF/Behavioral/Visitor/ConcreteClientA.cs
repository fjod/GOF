using System;

namespace GOF.Behavioral.Visitor
{
    public class ConcreteClientA : IVisitor
    {
        public void Work(ConcreteElementBase elementBase)
        {
            elementBase.Accept(this);
        }
        
        public void Visit(ConcreteElementA elementA)
        {
            Console.WriteLine(elementA.ImportantField);
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine(elementB.ID);
        }

        public void Visit(ConcreteElementC elementC)
        {
            Console.WriteLine(elementC.NumberField);
        }
    }
}