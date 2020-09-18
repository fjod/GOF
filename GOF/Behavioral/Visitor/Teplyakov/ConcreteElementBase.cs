namespace GOF.Behavioral.Visitor.Teplyakov
{
    public abstract class ConcreteElementBase
    {
        public abstract void Accept(IVisitor visitor);
        
    }
}