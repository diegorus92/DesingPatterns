using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    //Creator
    internal abstract class VehicleCreator
    {
        public abstract IVehicle CreateVehicle();


    }
}
