using System;
using System.Diagnostics;
using Ninject.Planning.Targets;

namespace GOF.Creational.AbstractFactory.Generic
{
    public class GenericFactory<K> where K : AbstractFactory
    {
        private static K _factory;

        public GenericFactory()
        {
            _factory = Activator.CreateInstance<K>();
        }

        static IPrinterA GetPrinterA()
        {
            return _factory.CreatePrinterA();
        }

        static IPrinterB GetPrinterB()
        {
            return _factory.CreatePrinterB();
        }

        public IPrinter Create<T>() where T: IPrinter
        {
            switch (typeof(T))
            {
                case var type when type == typeof(IPrinterA):
                    return GetPrinterA();
                case var type when type == typeof(IPrinterB):
                    return GetPrinterB();
            }
            throw new ArgumentException("not known type");
        }
    }
}