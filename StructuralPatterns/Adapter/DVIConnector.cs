using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    //Class to be connected to the adapted class
    public class DVIConnector : IDVIConnector
    {
        public string ReceiveDigitalVideoData()
        {
            return "Receiving Digital video Data...";
        }
    }
}
