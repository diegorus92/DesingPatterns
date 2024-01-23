using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    //Concrete Prototype 1
    internal class Dog : AnimalCloneable
    {
        public Dog(string name, string race):base(name, race) { }

        public override AnimalCloneable Clone()
        {
            return (AnimalCloneable) this.MemberwiseClone();
        }
    }
}
