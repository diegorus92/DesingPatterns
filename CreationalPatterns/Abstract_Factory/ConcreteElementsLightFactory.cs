using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Factory A
    internal class ConcreteElementsLightFactory : AbstractElementsFactory
    {
        public override IButton CreateButton()
        {
            return new LightButton();
        }

        public override ILabel CreateLabel()
        {
            return new LightLabel();
        }
    }
}
