using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstract_Factory
{
    //Concrete Product A2
    internal class DarkButton : IButton
    {
        public string Render()
        {
            return "Button rendering with DARK THEME";
        }
    }
}
