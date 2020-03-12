using System;

namespace GOF.Behavioral.Mediator
{
    public class ConcreteCollegue1 : IGetLine
    {
        public string GetLine()
        {
            NewMessage?.Invoke("Pattern Event Test");
            return "PatternTest";
        }

        public event Action<string> NewMessage;
    }
}