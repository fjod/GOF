using System;

namespace GOF.Creational.Builder
{
    public class Builder : IPatternTest
    {
        public void Implement()
        {
            Console.WriteLine();
            var c1 = new Client("sample1").ToUpper();
            Console.Write(c1.Message);
            
            Console.WriteLine();
            var c2 = new Client("SaMpLe2").ToLower();
            Console.Write(c2.Message);
            
            Console.WriteLine();
            var c3 = new Client("sammple4").PrettierMessage();
            Console.Write(c3.Message);
            Console.WriteLine();
        }

        public void Name()
        {
            Console.Write("Builder");
        }
    }
}