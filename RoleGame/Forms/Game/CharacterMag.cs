using Forms.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame
{
    public class CharacterMag : Character
    {
        private double mana;
        private double maxValue;
        public double Mana
        {
            get => mana;
            set
            {
                if(value < 0)
                    mana = 0;
                else if(value > maxValue)
                    mana = maxValue;
            }
        }
        public double MaxValue
        { get => maxValue;}
        public CharacterMag(double mana,double maxValue,string name, characterState state, characterRace race, characterGender gender, Vector startPosition, Vector size, Inventory inventory ) : base(name, state, race, gender,startPosition,size, inventory)
        {
            this.mana = mana;
            this.maxValue = maxValue;
        }
        public void HealthRecovery(Character obj,double mana)
        {
            if(this.mana-mana < 0)
            {
                Console.WriteLine("Невозможно воспользоваться заклинанием");
                return;
            }
            obj.Health += mana / 2;
            this.mana -= mana;
        }
    }
}
