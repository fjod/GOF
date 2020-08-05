namespace GOF.Structural.Decorator
{
    /// <summary>
    /// base decorator implements same interface for all decorators
    /// </summary>
    public abstract class Decorator : Printer
    {
        private readonly Printer _printer;

        protected Decorator(Printer printer)
        {
            _printer = printer;
        }

        public override void Print()
        {
            //some additional code may be here
            _printer?.Print();
        }
    }
}