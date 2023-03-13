using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame.Magic
{
    internal class Otomri : Spell
    {
        public Otomri(CharacterMag character) : base(character, 85)
        {
        }
        public override void PerformMagic()
        {
            this.magCharacter.State = characterState.weak;
            this.magCharacter.Mana -= minMana;
            return;
        }

        public override void PerformMagic(Character aimCharacter)
        {
            aimCharacter.State = characterState.weak;
            this.magCharacter.Mana -= minMana;
            return;
        }

        public override void PerformMagic(double impactForce)
        {
            if (impactForce <= 0.5)
            {
                this.magCharacter.State = characterState.weak;
                this.magCharacter.Mana -= minMana;
                return;
            }
            else
            {
                this.magCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana * 1.5;
                return;
            }
        }

        public override void PerformMagic(Character aimCharacter, double impactForce)
        {
            if (impactForce <= 0.5)
            {
                aimCharacter.State = characterState.weak;
                this.magCharacter.Mana -= minMana;
                return;
            }
            else
            {
                aimCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana * 1.5;
                return;
            }
        }
        public override string ToString()
        {
            return "Отомри!";
        }
    }
}
