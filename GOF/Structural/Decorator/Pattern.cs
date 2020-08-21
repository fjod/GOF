using System;

namespace GOF.Structural.Decorator
{
    //idea is to wrap some object inherited from interface/abstract class 
    //but the wrap is around interface method/abstract class method
    //so we can pass our decorator to client
    //and do something with how client uses some initial object
    
    // The main difference I see is that
    // when we assume that Proxy uses composition and
    // Decorator uses aggregation then it seems to be clear
    // that by using multiple (one or more) Decorators you can modify/ add functionalities
    // to pre-existing instance (decorate),
    // whereas Proxy has own inner instance of proxied class and delegates to it
    // adding some additional features (proxy behaviour).
    public class Pattern : IPatternTest
    {
        public void Implement()
        {
            //non-decorated object here
            Client client = new Client();
            var initialObject = new ConcretePrinter();
            client.ClientWork(initialObject);
            
            //decorated object
            ConcreteDecorator cd1 = new ConcreteDecorator(initialObject);
            client.ClientWork(cd1);
            
            //decorator around decorator around object
            SecondDecorator cd2 = new SecondDecorator(cd1);
            client.ClientWork(cd2);
        }

        public void Name()
        {
          Console.WriteLine("===============Decorator pattern===============");
        }
    }
}