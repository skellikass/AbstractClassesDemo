using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public string SizeOfEngine { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This vehicle is not recommended for families.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This vehicle has two wheels.");
        }
        public override void PrintVehicleDetails()
        {
            Console.WriteLine($" has a {SizeOfEngine} engine.  It has a sidecar: {HasSidecar}");
        }
    }
}
