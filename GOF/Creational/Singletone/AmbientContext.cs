using System;

namespace GOF.Creational.Singletone
{
    public interface ISingleTonPattern
    {
        void Print();
    }

    internal class DefaultPrinter :ISingleTonPattern
    {
        public void Print()
        {
            Console.WriteLine("Ambient Singletone");
        }
    }

    public class Singletone2 : IPatternTest
    {
        private static ISingleTonPattern _pattern = new DefaultPrinter();
        public static ISingleTonPattern Pattern
        {
            get { return _pattern; }
            internal set { _pattern = value; }
        }
        public void Implement()
        {
            Pattern.Print();
        }

        public void Name()
        {
            Console.WriteLine("Singletone2");
        }
    }
    
    
}