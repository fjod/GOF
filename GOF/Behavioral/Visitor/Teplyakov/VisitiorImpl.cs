using System;

namespace GOF.Behavioral.Visitor.Teplyakov
{
    /*
     * There are several classes, inherited from base one (ConcreteElementBase)
     * they wont change much and the amount of such classes should not change,
     * but we want to do some operations with them in client
     * it depends on client  what to do with them
     * if there is new inherited class, IVisitor interface must be updated - that's the downside
     *
     * to extend former class one can use extension methods if properties are accesible
     */
    public class VisitiorImpl : IPatternTest
    {
        public void Implement()
        {
            var elementA = new ConcreteElementA();
            var elementB = new ConcreteElementB();
            var elementC = new ConcreteElementC();
            ConcreteClientA clientA = new ConcreteClientA();
            clientA.Work(elementA);
            clientA.Work(elementB);
            
            ConcreteClientB clientB = new ConcreteClientB();
            clientB.AnotherJob(elementC);
            clientB.AnotherJob(elementA);
            
        }

        public void Name()
        {
            Console.WriteLine("====Visitor Teplyakov====");
        }
    }
}