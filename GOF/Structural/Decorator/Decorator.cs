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
            //some additional code should be here 
            //measure stuff
            //or if it's even possible to call it at all
            _printer?.Print();
        }
    }
}