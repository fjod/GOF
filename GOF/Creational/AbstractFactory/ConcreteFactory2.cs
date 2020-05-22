namespace GOF.Creational.AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override IPrinterA CreatePrinterA()
        {
            return new PrinterA2();
        }

        public override IPrinterB CreatePrinterB()
        {
            return new PrinterB();
        }
    }
}