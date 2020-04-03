using System;
using System.Collections.Generic;

namespace GOF.Behavioral.Observer
{
    public class ConcreteSubject : ISubject, IObservable<string>
    {
        private int PersonalNumber;
        private readonly Action<string> _callback;
        private List<IVanillaObserver> _vanillaObservers = new List<IVanillaObserver>();

        private List<IObserver<string>> interfaceObservers;
        public ConcreteSubject(Action<string> callback, int personalNumber)
        {
            this.PersonalNumber = personalNumber;
            _callback = callback;
            interfaceObservers = new List<IObserver<string>>();
        }
        public void Attach(IVanillaObserver vanillaObserver)
        {
            _vanillaObservers.Add(vanillaObserver);
        }

        public void Detach(IVanillaObserver vanillaObserver)
        {
            _vanillaObservers.Remove(vanillaObserver);
        }

        public event Action<string> Event;
        public void Notify()
        {
            _vanillaObservers.ForEach(f => f.Update($"ConcreteSubject {PersonalNumber}"));
            _callback($"ConcreteSubjectDelegate {PersonalNumber}");
            Event?.Invoke($"ConcreteSubjectEvent {PersonalNumber}");
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (! interfaceObservers.Contains(observer)) 
                interfaceObservers.Add(observer);
            return new Unsubscriber(interfaceObservers, observer);
        }
        
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>>_observers;
            private IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void UseObserver()
        {
            interfaceObservers.ForEach( obs => obs.OnNext($"UseObserver {PersonalNumber}"));
        }
        public void StopObserving()
        {
            interfaceObservers.ForEach( obs => obs.OnCompleted());
        }
    }
}