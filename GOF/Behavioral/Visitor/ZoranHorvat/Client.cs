using System;
using System.Collections.Generic;

namespace GOF.Behavioral.Visitor.ZoranHorvat
{
    public class Client
    {
        private IEnumerable<Car> cars;

        public Client(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }
        
        public void Render()
        {
            foreach (Car car in this.cars)
            {
                CarToStringVisitor converter = new CarToStringVisitor();
                car.Accept(converter);
                Console.WriteLine(converter.GetCarDescription());
            }
        }

        public void GetOnlyParts()
        {
            foreach (Car car in this.cars)
            {
                CarDetailsVisitor converter = new CarDetailsVisitor();
                car.Accept(converter);
                Console.WriteLine(converter.GetCarDescription());
            }
        }
    }
}