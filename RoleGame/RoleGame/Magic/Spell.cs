using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame.Magic
{
    public abstract class Spell : IMagic
    {
        protected CharacterMag magCharacter;
        protected double minMana;
        
        public Spell(CharacterMag character, double minMana)
        {
            this.magCharacter = character;
            this.minMana = minMana;
        }

        public void verbal()
        {
            Console.WriteLine("Персонаж произносит заклинание");
        }
        public void motor()
        {
            Console.WriteLine("Персонаж выполняет какие-то движения");
        }

        public abstract void PerformMagic();

        public abstract void PerformMagic(Character aimCharacter);

        public abstract void PerformMagic(double impactForce);


        public abstract void PerformMagic(Character aimCharacter, double impactForce);
    }
}