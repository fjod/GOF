using System;

namespace GOF.Structural.Proxy
{
    public class RealSubject : IPrint
    {
        public void Print()
        { 
            Console.WriteLine("RealSubject here");
        }
    }
}