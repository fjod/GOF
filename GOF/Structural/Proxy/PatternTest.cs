using System;

namespace GOF.Structural.Proxy
{
    //proxy is when we should do some work before calling actual operator
    //just like Lazy<T>
    //or encrypting parameters 
    //caching
    //access rights
    //client does not know about actual object
    
    //it's is similar to decorator but decorator adds something to methods, allowing chaining
    //proxy should not change results of pattern job done
    public class PatternTest : IPatternTest
    {
        public void Implement()
        {
             Client client = new Client();
             var subj = new RealSubject();
             client.UsePrinter(subj);
             client.UsePrinter(new Proxy(subj));
        }

        public void Name()
        {
            Console.WriteLine("Proxy pattern");
        }
    }
}