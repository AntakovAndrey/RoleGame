﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGame
{
    internal class BottleOfDeadWater:Artefact
    {
        public void SmallBattleOfDeadWater(CharacterMag characterMag)
        {
            characterMag.Mana += 10;
            Console.WriteLine("Mана персонажа увеличено на 10 едениц");
        }
        public void AvvarageBattleOfLivingWater(CharacterMag characterMag)
        {
            characterMag.Mana += 25;
            Console.WriteLine("Mана персонажа увеличено на 25 едениц");
        }
        public void BigBattleOfLivingWater(CharacterMag characterMag)
        {
            characterMag.Mana += 50;
            Console.WriteLine("Mана персонажа увеличено на 50 едениц");
        }
    }
}
