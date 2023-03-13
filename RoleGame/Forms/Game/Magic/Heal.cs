using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame.Magic
{
    internal class Heal : Spell
    {
        public Heal(CharacterMag character) : base(character, 20)
        {
        }

        public override void PerformMagic()
        {
            if (this.magCharacter.State == characterState.sick)
            {
                this.magCharacter.State = characterState.weak;
                this.magCharacter.Mana -= minMana;
                return;
            }
            else if (this.magCharacter.State == characterState.weak)
            {
                this.magCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana;
                return;
            }
        }

        public override void PerformMagic(Character aimCharacter)
        {
            if (aimCharacter.State == characterState.sick)
            {
                aimCharacter.State = characterState.weak;
                magCharacter.Mana -= minMana;
                return;
            }   
            else if(aimCharacter.State==characterState.weak)
            {
                aimCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana;
                return;
            }                
        }

        public override void PerformMagic(double impactForce)
        {
            if (this.magCharacter.State == characterState.sick)
            {
                this.magCharacter.State = characterState.weak;
                this.magCharacter.Mana -= minMana;
                return;
            }
            else if (this.magCharacter.State == characterState.weak)
            {
                this.magCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana;
                return;
            }
        }

        public override void PerformMagic(Character aimCharacter, double impactForce)
        {
            if (aimCharacter.State == characterState.sick)
            {
                aimCharacter.State = characterState.weak;
                magCharacter.Mana -= minMana;
                return;
            }
            else if (aimCharacter.State == characterState.weak)
            {
                aimCharacter.State = characterState.normal;
                magCharacter.Mana -= minMana;
                return;
            }
        }
        public override string ToString()
        {
            return "Вылечить";
        }
    }
}
