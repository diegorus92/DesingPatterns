using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Product B2
    internal class DarkLabel : ILabel
    {
        public string GetText()
        {
            return "This text have DARK THEME";
        }
    }
}
