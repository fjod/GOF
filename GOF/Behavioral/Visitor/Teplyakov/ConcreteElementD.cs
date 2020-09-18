namespace GOF.Behavioral.Visitor.Teplyakov
{
    public class ConcreteElementD
    {
        public string ImportantField { get; }

        public ConcreteElementD()
        {
            ImportantField = "ConcreteTypeA";
        }
    }

    public static class DExt
    {
        public static void Accept(this ConcreteElementD elementD, IVisitor visitor)
        {
            visitor.Visit(elementD);
        }
    }
}