using System;

namespace GOF.Behavioral.Observer
{
    public class Observer : IPatternTest
    {
        //the idea of this pattern is that there is a class which observes another class
        //one class notifies another classes about something
        public void Implement()
        {
            var observer = new  ConcreteVanillaObserver();
            var subject1 = new ConcreteSubject(Callback,1); //it can be a delegate
            var subject2 = new ConcreteSubject(Callback,2);
            subject1.Event += Callback; //it can be event
            subject2.Event += Callback;

            subject1.Attach(observer); //it can be done by writing interface by hand
            subject2.Attach(observer);
            
            subject1.Notify();//it should be called internally in subject ofc
            subject2.Notify();

            subject1.Subscribe(observer); //or one can use IObservable and IObserver
            subject2.Subscribe(observer);
            
            subject1.UseObserver(); //also done internally
            subject2.UseObserver();
            
            subject1.Detach(observer); //and detach observers on dispose
            subject2.Detach(observer); 
            subject1.StopObserving();
            subject2.StopObserving();
        }

        private void Callback(string obj)
        {
            Console.WriteLine(obj);
        }

        public void Name()
        {
            Console.WriteLine("===Observer Pattern=====");
        }
    }
}