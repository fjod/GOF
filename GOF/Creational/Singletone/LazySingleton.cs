using System;

namespace GOF.Creational.Singletone

{
    public sealed class SomeSingleTone
    {
        public string Random { get; }
        public SomeSingleTone()
        {
            Random r = new Random();
            Random = "Random double from singleTone is = " + r.NextDouble().ToString("F1");
        }
    }
    public  class LazySingleton : IPatternTest
    {
        private static readonly Lazy<SomeSingleTone> _instance = new Lazy<SomeSingleTone>(() => new SomeSingleTone());

        public static Lazy<SomeSingleTone> Instance => _instance;

        

        public void Implement()
        {
            Console.WriteLine(Instance.Value.Random);
            Console.WriteLine("Print singletone");
        }

        public void Name()
        {
            Console.WriteLine("Singletone");
        }
    }
}