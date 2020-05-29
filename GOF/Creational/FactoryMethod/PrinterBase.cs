namespace GOF.Creational.FactoryMethod
{
    public abstract class PrinterBase
    {
        protected abstract IPrintText Printer();

        public void Print()
        {
            Printer().Print("Some Text");
        }
    }
    
    
}