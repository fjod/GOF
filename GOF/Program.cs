using System;
using GOF.Behavioral.Mediator;
using GOF.Behavioral.Strategy;
using GOF.Behavioral.TemplateMethod;
using Ninject;
using Ninject.Extensions.Conventions;

namespace GOF
{
    class Program
    {
        private static StandardKernel _kernel;
        static void Main(string[] args)
        {
            Injector();
            foreach (var patternTest in _kernel.GetAll<IPatternTest>())
            {
                patternTest.Name();
                patternTest.Implement();
                Console.WriteLine("--------------------");
            }
        }

        static void Injector()
        {
            _kernel = new StandardKernel();
            _kernel.Bind(
                x => x.FromThisAssembly()
                    .SelectAllClasses().BindAllInterfaces()
                    );
        }
    }
}