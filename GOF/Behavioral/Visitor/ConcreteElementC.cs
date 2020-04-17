namespace GOF.Behavioral.Visitor
{
    public class ConcreteElementC : ConcreteElementBase
    {
        static int _counter;
        public int NumberField => _counter;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public ConcreteElementC()
        {
            _counter++;
        }
    }
}