using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class VGAToDVIAdapter : IDVIConnector
    {
        private VGACable _vgaCable;

        public VGAToDVIAdapter(VGACable vgaCable)
        {
            _vgaCable = vgaCable;
        }



        public string ReceiveDigitalVideoData()
        {
            return $"VGA cable connected to DVI connector: {_vgaCable.TransmitAnalogVideoData()} --> Transforming to Digital signal for send to DVI";
        }
    }
}
