using System;
using Ninject;
using Ninject.Extensions.Conventions;

namespace GOF
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Bind(x => x.FromThisAssembly()
                    .SelectAllClasses().BindAllInterfaces());

            foreach (var patternTest in kernel.GetAll<IPatternTest>())
            {
                patternTest.Name();
                patternTest.Implement();
                Console.WriteLine("--------------------");
            }
        }
    }
}