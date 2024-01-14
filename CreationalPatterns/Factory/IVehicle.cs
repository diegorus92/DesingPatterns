using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    //Porduct. Here is declare all methods commons to all concrete products
    //(all vehicles types in this case)
    internal interface IVehicle
    {
        public string RunVehicle();
    }
}
