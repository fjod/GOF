using System;

namespace GOF.Structural.Facade
{
    /// <summary>
    /// there is some complicated system and we can make working with it easier
    /// using some wrappers/adapters
    /// also using facades is nice for testing, we can swap underlying system
    /// and use previous tests
    /// </summary>
    public class Facade : IPatternTest
    {
        public void Implement()
        {
            PrinterFacade pf = new PrinterFacade();
            pf.PrintString("printing...");
        }

        public void Name()
        {
            Console.WriteLine("Facade");
        }
    }
}