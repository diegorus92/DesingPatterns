using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Product A1
    internal class LightButton : IButton
    {
        public string Render()
        {
            return "Button rendering with LIGHT THEME";
        }
    }
}
