using System;

namespace GOF.Creational.Singletone
{
    public sealed class LazySingleton : IPatternTest
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static Lazy<LazySingleton> Instance => _instance;

        public void Implement()
        {
            Console.WriteLine("SingleTone pattern");
        }

        public void Name()
        {
            Console.WriteLine("Singletone");
        }
    }
}