using System;

namespace GOF.Behavioral.Visitor
{
    public abstract class ConcreteElementBase
    {
        public abstract void Accept(IVisitor visitor);
        
    }
}