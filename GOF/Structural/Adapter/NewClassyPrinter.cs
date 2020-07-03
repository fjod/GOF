using System;

namespace GOF.Structural.Adapter
{
    public class NewClassyPrinter
    {
        string String { get;  }

        public NewClassyPrinter(string s)
        {
            String = s;
        }

        public void Prints500PagesPerSecond(string s)
        {
            Console.WriteLine("woof woof");
            Console.WriteLine(s);
        }

        public void ItCanPrintToo()
        {
            Console.WriteLine("newClassyPrinter " +String.ToUpper());
        }
    }
}