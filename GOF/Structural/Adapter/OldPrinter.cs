using System;

namespace GOF.Structural.Adapter
{
    public class OldPrinter
    { 
        string String { get;  }

        public OldPrinter(string s)
        {
            String = s;
        }

        public void OldJammyPrintingDevice(string s)
        {
            Console.WriteLine("JAM JAM");
            Console.WriteLine(s);
        }
        public void PrintString()
        {
            Console.WriteLine(String);
        }
    }
}