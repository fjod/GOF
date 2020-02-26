using GOF.Behavioral.Strategy;
using Ninject;

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
            }
        }

        static void Injector()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IPatternTest>().To<Strategy>();
        }
    }
}