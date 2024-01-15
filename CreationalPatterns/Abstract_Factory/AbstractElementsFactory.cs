using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    internal abstract class AbstractElementsFactory
    {
        public abstract IButton CreateButton(); //CreateProductA
        public abstract ILabel CreateLabel(); //CreateProductB
    }
}
