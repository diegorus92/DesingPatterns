using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Factory B
    internal class ConcreteElementsDarkFactory : AbstractElementsFactory
    {
        public override IButton CreateButton()
        {
            return new DarkButton();
        }

        public override ILabel CreateLabel()
        {
            return new DarkLabel();
        }
    }
}
