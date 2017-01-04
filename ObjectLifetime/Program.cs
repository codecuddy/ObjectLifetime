using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Chevy", "Equinox", 2014, "Black");
            /*
            myCar.Make = "Dodge";
            myCar.Model = "Neon";
            myCar.Year = 1997;
            myCar.Color = "White";
            */

            /*
            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}",
               myOtherCar.Make,
               myOtherCar.Model,
               myOtherCar.Year,
               myOtherCar.Color);

            myOtherCar.Model = "Ranger";
            myOtherCar.Year = 2004;
            */


            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            // myOtherCar = null;
            
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*
        public Car()
        {
            // You could load form a configuration file, database, etc.
            // comes pre loaded when you create it at an instance
            Make = "Nissan";
        }
        */

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color; 
        }
    }
}
