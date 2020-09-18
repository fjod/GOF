

namespace GOF.Behavioral.Visitor.Teplyakov
{
    public class ConcreteElementA : ConcreteElementBase
    {
        public string ImportantField { get;}

        public ConcreteElementA()
        {
            ImportantField = "ConcreteTypeA";
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

     
    }
}