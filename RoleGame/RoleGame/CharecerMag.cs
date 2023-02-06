using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame
{
    internal class CharecerMag : Character
    {
        private double mana;
        private double maxValue;
        public double Mana
        { get => mana; set => mana = value; }
        public double MaxValue
        { get => maxValue; set => maxValue = value; }
        public CharecerMag(double mana,double maxValue,string name, characterState state, characterRace race, characterGender gender) : base(name, state, race, gender)
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
            obj.
        }
    }
}
