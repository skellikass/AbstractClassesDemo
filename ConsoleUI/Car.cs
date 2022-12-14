using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle is recommended for families.");
        }
        public override void PrintVehicleDetails()
        {
            Console.WriteLine($" has {NumberOfDoors} doors.  It has a trunk: {HasTrunk}");
        }
    }
}
