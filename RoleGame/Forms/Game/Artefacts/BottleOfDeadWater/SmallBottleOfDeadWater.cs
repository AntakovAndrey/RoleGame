using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.Engine;
using RoleGame;

namespace Forms.Game.Artefacts.BottleOfLivingWater
{
    internal class SmallBottleOfDeadWater : Artefact
    {
        

        //public void SmallBattleOfDeadWater(CharacterMag characterMag)
        //{
            
        //}
        //public void AvvarageBattleOfLivingWater(CharacterMag characterMag)
        //{
        //    characterMag.Mana += 25;
        //    Console.WriteLine("Mана персонажа увеличено на 25 едениц");
        //}
        //public void BigBattleOfLivingWater(CharacterMag characterMag)
        //{
        //    characterMag.Mana += 50;
        //    Console.WriteLine("Mана персонажа увеличено на 50 едениц");
        //}

        public override void Perform(IGameObject aim, int power)
        {
            if(aim is CharacterMag mag)
                mag.Mana+= 10;
           // Console.WriteLine("Mана персонажа увеличено на 10 едениц");
        }
    }
}
