using System;

namespace GOF.Creational.AbstractFactory
{
    public class FactoryForFactories
    {
        public AbstractFactory GetFactory(int number)
        {
            switch (number)
            {
                case 1: return new ConcreteFactory1();
                case 2: return new ConcreteFactory2();
                default: throw new ArgumentException();
            }
        }
    }
}