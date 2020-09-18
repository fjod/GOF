namespace GOF.Behavioral.Visitor.Teplyakov
{
    public interface IVisitor
    {
        void Visit(ConcreteElementA elementA);
        void Visit(ConcreteElementB elementB);
        void Visit(ConcreteElementC elementC);
        
        void Visit(ConcreteElementD elementD);
    }
}