using BenchmarkTest.VirtualVehicleClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.VehiclesInheritance
{
    public class BicycleInheritance : Vehicle
    {
        public override void GetWheelsCount() 
        {
            Console.WriteLine("Inherited bicycle has 2 wheels.");
        }
    }
}
