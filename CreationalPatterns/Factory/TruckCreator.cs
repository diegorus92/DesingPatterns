using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    //Concrete Creator
    internal class TruckCreator : VehicleCreator
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
