using System;

namespace GOF.Behavioral.Iterator
{
    public class Iterator: IPatternTest
    {
        //Iterator represents moving through some collection
        //Client does not know how move from one element to another is implemented
        public void Implement()
        {
            var test = new ConcreteIterator();
            foreach (var str in test)
            {
                Console.WriteLine(str);
            }
            
            var test2 = new ConcreteIterator3();
            foreach (var str in test2)
            {
                Console.WriteLine(str);
            }
        }

        public void Name()
        {
            Console.WriteLine("Iterator pattern");
        }
    }
}