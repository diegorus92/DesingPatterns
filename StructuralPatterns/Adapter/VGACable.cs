using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    //Class to adapt
    public class VGACable : IVGACable
    {
        public string TransmitAnalogVideoData()
        {
            return "VGA cable connected and transmiting analog video data";
        }
    }
}
