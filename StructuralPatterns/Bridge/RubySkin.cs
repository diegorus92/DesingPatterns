using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class RubySkin : ISkin
    {
        private readonly string _name;
        private bool _isSkinApplyOnCharacter;

        public RubySkin(string name)
        {
            _name = name;
            _isSkinApplyOnCharacter = false;
        }


        public string Name => _name;
        public bool IsSkinApplyOnCharacter 
        { 
            get { return _isSkinApplyOnCharacter; } 
            set { _isSkinApplyOnCharacter = value; } 
        }


        public void ApplySkinToCharacter()
        {
            if (IsSkinApplyOnCharacter)
            {
                Console.WriteLine($"Skin {Name} already apply on character");
            }
            else
            {
                IsSkinApplyOnCharacter = true;
                Console.WriteLine($"Skin {Name} applied!");
            }
        }

        public void ChangeSkinVariant()
        {
            Console.WriteLine("Skin variant changed");
        }

        public void RemoveSkinFromCharacter()
        {

            if (IsSkinApplyOnCharacter)
            {
                IsSkinApplyOnCharacter = false;
                Console.WriteLine($"Skin removed!");
            }
            else
            {
                Console.WriteLine($"Skin it's not applied on Character");
            }
        }
    }
}
