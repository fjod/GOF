using System;

namespace GOF.Behavioral.Mediator
{
    public interface IGetLine
    {
        string GetLine();
        public event Action<string> NewMessage;
    }
}