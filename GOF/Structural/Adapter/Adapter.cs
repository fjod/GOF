using System;

namespace GOF.Structural.Adapter
{
    //The idea is to use old classes in some unified way
    //you cant change them
    //It can be done using some wrappers, which implement some interface
    public class Adapter : IPatternTest
    {
        public void Implement()
        {
            IPrintAdapted first = new AdapterForNewPrinter(new NewClassyPrinter("Nice"));
            IPrintAdapted second = new AdapterForOldPrinter(new OldPrinter("Cool"));
            SomethingThatPrintsThings things = new SomethingThatPrintsThings();
            things.UseAdapted(first);
            things.UseAdapted(second);
        }

        public void Name()
        {
            Console.WriteLine("Adapter pattern");
        }
    }
}