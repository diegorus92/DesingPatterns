using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    //Abstraction
    public class Character 
    {
        private ISkin _skin;

        public Character(ISkin skin)
        {
            _skin = skin;
        }

        public ISkin Skin 
        { get { return _skin; }
          set 
          {
            _skin = value;
            _skin.IsSkinApplyOnCharacter = true;
          }
        }


        public void ApplySkin()
        {
            _skin.ApplySkinToCharacter();
        }

        public void RemoveSkin()
        {
            _skin.RemoveSkinFromCharacter();
        }

        public void ChangeVariant()
        {
            _skin.ChangeSkinVariant();
        }
        
    }
}
