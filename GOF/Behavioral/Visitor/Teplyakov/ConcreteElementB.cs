using System;

namespace GOF.Behavioral.Visitor.Teplyakov
{
    public class ConcreteElementB :ConcreteElementBase
    {
        public Guid ID => Guid.NewGuid();
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

  
    }
}