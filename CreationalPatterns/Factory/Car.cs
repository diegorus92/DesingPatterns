using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    //Concrete Product
    internal class Car : IVehicle
    {
        public string RunVehicle()
        {
            return $"Driving a {this.GetType().Name}";
        }
    }
}
