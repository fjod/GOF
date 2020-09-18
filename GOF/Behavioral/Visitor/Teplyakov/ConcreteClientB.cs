using System;

namespace GOF.Behavioral.Visitor.Teplyakov
{
    public class ConcreteClientB : IVisitor
    {
        public void AnotherJob(ConcreteElementBase elementBase)
        {
            elementBase.Accept(this);
        }
        public void Visit(ConcreteElementA elementA)
        {
            Console.WriteLine(elementA.ImportantField.Length);
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine(elementB.ID.ToString().Length);
        }

        public void Visit(ConcreteElementC elementC)
        {
            Console.WriteLine(elementC.NumberField);
        }

        public void Visit(ConcreteElementD elementD)
        {
            throw new NotImplementedException();
        }
    }
}