using System;

namespace GOF.Creational.AbstractFactory
{
    public class Client : IPatternTest
    {
        public void Implement()
        {
            ConcreteFactory1 cf = new ConcreteFactory1(); //the problem is who is creating it?
            cf.CreatePrinterA().PrintText();
            cf.CreatePrinterB().PrintText(); //in easy cases we create it by hand
            
            //or we can have factory for factories!
            FactoryForFactories ff = new FactoryForFactories();
            ff.GetFactory(2).CreatePrinterA().PrintText();
            ff.GetFactory(1).CreatePrinterB().PrintText();
            
            //or even move it to generic
            var factory = new Generic.GenericFactory<ConcreteFactory1>();
            var printerA = factory.Create<IPrinterA>();
            (printerA as IPrinterA).PrintText();
        }

        public void Name()
        {
            Console.WriteLine("Abstract factory");
        }
    }
}