using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    internal abstract class AnimalCloneable //Prototype
    {
        private string _name;
        private string _race;

        public string Name { get { return _name; } }
        public string Race { get { return _race; } }

        public AnimalCloneable(string name, string race)
        {
            _name = name;
            _race = race;
        }

        public abstract AnimalCloneable Clone();
    }
}
