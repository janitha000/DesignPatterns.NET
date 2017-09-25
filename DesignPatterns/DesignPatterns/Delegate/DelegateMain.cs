using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Delegate
{
    class DelegateMain
    {
        public delegate bool FilterDelegate(Car car);
        static void Main(string[] args)
        {
            Car Allion = new Car() { Name = "Allion", Price = 60, Year = 2014 };
            Car Lambo = new Car() { Name = "Lambo", Price = 140, Year = 2017 };
            Car Alto = new Car() { Name = "Alto", Price = 20, Year = 2011 };
            Car Benz = new Car() { Name = "Benz", Price = 120, Year = 2016 };

            List<Car> cars = new List<Car>() { Allion, Lambo, Alto, Benz };

            Display(cars, IsMoreThanGrand);
            Display(cars, IsOld);
            Display(cars, IsMidPrice);

        }

        public static void Display(List<Car> cars, FilterDelegate filter)
        {
            foreach (Car car in cars)
            {
                if (filter(car))
                {
                    Console.WriteLine(car.Name);
                }
            }
        }

        static bool IsMoreThanGrand(Car car)
        {
            return car.Price > 100;
        }
        static bool IsOld(Car car)
        {
            return car.Year < 2013;
        }

        static bool IsMidPrice(Car car)
        {
            return car.Price < 100;
        }



    }
}
