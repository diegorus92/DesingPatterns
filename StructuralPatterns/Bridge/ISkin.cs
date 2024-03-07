using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    //Implementation
    public interface ISkin
    {
        public string Name { get; }
        public bool IsSkinApplyOnCharacter { get; set; }

        public void ApplySkinToCharacter();
        public void RemoveSkinFromCharacter();
        public void ChangeSkinVariant();
    }
}
