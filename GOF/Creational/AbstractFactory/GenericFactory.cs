using System;
using Ninject.Planning.Targets;

namespace GOF.Creational.AbstractFactory
{
    public class GenericFactory
    {
        public T MakeFactory<T>(string name) where T: IPrinterA , new()
        {

            var printer = new PrinterA();
            return printer;
        }
    }
}