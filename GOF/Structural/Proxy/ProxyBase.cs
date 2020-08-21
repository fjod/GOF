using System;

namespace GOF.Structural.Proxy
{
    public abstract class ProxyBase<T>: IPrint where T:IPrint
    {
        private readonly T _print;
        
        protected ProxyBase(T print)
        {
            _print = print;
        }
        public void Print()
        {
           Console.WriteLine("Some additional work in Proxy");
           _print.Print();
        }
    }
}