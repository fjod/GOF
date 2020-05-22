namespace GOF.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IPrinterA CreatePrinterA();
        public abstract IPrinterB CreatePrinterB();
    }
}