using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Product B1
    internal class LightLabel : ILabel
    {
        public string GetText()
        {
            return "This text have LIGHT THEME";
        }
    }
}
