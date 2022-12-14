using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehiclesList = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car car1 = new Car() { Year = "1995", Make = "Pontiac", Model = "Grand Prix", HasTrunk = true, NumberOfDoors = 4 };
            Motorcycle moto1 = new Motorcycle() { Year = "1999", Make = "Yamaha", Model = "Roadstar", HasSidecar = false, SizeOfEngine = "1600cc" };
            Vehicle car2 = new Car() { Year = "2007", Make = "BMW", Model = "325i", HasTrunk = true, NumberOfDoors = 4 };
            Vehicle moto2 = new Motorcycle() { Year = "1999", Make = "Kawasaki", Model = "Vulcan", HasSidecar = false, SizeOfEngine = "750cc" };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehiclesList.Add(car1);
            vehiclesList.Add(car2);
            vehiclesList.Add(moto1);
            vehiclesList.Add(moto2);


            foreach (var item in vehiclesList)
            {
                Console.Write($"The {item.Year} {item.Make} {item.Model}");
                item.PrintVehicleDetails();
                item.DriveAbstract();
                item.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle


            #endregion
             Console.ReadLine();
        }
    }
}
