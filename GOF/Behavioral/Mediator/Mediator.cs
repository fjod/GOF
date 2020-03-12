using System;

namespace GOF.Behavioral.Mediator
{
    //mediator class links several classes between
    public class Mediator : IPatternTest
    {
        //these classes do not know about each other
        private IGetLine getter;
        private IPrintLine printer;

        public Mediator()
        {
            getter = new ConcreteCollegue1();
            printer = new ConcreteCollegue2();
            //we can use messages from one to another
            getter.NewMessage += s => printer.Print(s);
        }
        
        //we can use direct calls from one to another
        public void Implement()
        {
            printer.Print(getter.GetLine());
        }

        public void Name()
        {
            Console.WriteLine("Mediator pattern");
        }
    }
}