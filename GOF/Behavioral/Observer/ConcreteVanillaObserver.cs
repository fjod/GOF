using System;

namespace GOF.Behavioral.Observer
{
    public class ConcreteVanillaObserver : IVanillaObserver, IObserver<string>
    {
        public ConcreteVanillaObserver()
        {
        }

        private IDisposable unsub;

        public void Subscribe(IObservable<string> provider)
        {
            unsub = provider.Subscribe(this);
        }

        public void Update(string temp)
        {
            Console.WriteLine(temp);
        }

        public void OnCompleted()
        {
            Console.WriteLine("IObserver completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("IObserver error");
        }

        public void OnNext(string value)
        {
            Console.WriteLine($"IObserver next {value}");
        }
    }
}