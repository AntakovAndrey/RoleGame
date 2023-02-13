using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame.Magic
{
    internal class AddHealth : Spell
    {
        public AddHealth(CharacterMag character) : base(character, 0)
        {}

        public override void PerformMagic()
        {
            this.magCharacter.Health += this.magCharacter.Mana / 2;
        }

        public override void PerformMagic(Character aimCharacter)
        {
            aimCharacter.Health += this.magCharacter.Mana / 2;
        }

        public override void PerformMagic(double impactForce)
        {
            this.magCharacter.Health += this.magCharacter.Mana*impactForce / 2;
        }

        public override void PerformMagic(Character aimCharacter, double impactForce)
        {
            aimCharacter.Health += this.magCharacter.Mana * impactForce / 2;
        }
    }
}
