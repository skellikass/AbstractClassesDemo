using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
        public string Year { get; set; } = "Year";
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is a vehicle.");
        }
        public abstract void PrintVehicleDetails();
    }
}
