namespace GOF.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(ConcreteElementA elementA);
        void Visit(ConcreteElementB elementB);
        void Visit(ConcreteElementC elementC);
    }
}