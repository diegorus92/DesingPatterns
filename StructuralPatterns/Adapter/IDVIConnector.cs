using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public interface IDVIConnector
    {
        public string ReceiveDigitalVideoData();
    }
}
