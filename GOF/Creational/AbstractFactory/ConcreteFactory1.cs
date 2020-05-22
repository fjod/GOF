namespace GOF.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override IPrinterA CreatePrinterA()
        {
            return new PrinterA();
        }

        public override IPrinterB CreatePrinterB()
        {
            return new PrinterB();
        }
    }
}