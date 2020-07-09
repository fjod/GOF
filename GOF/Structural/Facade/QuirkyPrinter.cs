using System;

namespace GOF.Structural.Facade
{
    public class QuirkyPrinter
    {
        private bool isOn;
        public void PowerOn()
        {
            isOn = true;
            Console.WriteLine("Printer on");
        }

        private bool paperOk;
        public void InsertPaper()
        {
            if (!isOn) throw new Exception("Printer must be on");
            Console.WriteLine("Paper ok");
            paperOk = true;
        }

        public void PrintSomething(string s)
        {
            if (!isOn) throw new Exception("Printer must be on");
            if (!paperOk) throw new Exception("Printer must have some paper");
            Console.WriteLine(s);
        }
    }
}