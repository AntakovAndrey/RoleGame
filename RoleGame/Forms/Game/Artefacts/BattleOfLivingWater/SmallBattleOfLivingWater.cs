using System;
using Forms.Engine;
using RoleGame;

namespace Forms.Game.Artefacts.BattleOfLivingWater
{
    internal class SmallBattleOfLivingWater : Artefact
    {
        //public void SmallBattleOfLivingWater(Character character)
        //{
        //    character.Health += 10;
        //    Console.WriteLine("Здоровье персонажа увеличено на 10 едениц");
        //}
        //public void AvvarageBattleOfLivingWater(Character character)
        //{
        //    character.Health += 25;
        //    Console.WriteLine("Здоровье персонажа увеличено на 25 едениц");
        //}
        //public void BigBattleOfLivingWater(Character character)
        //{
        //    character.Health += 50;
        //    Console.WriteLine("Здоровье персонажа увеличено на 50 едениц");
        //}

        public override void Perform(IGameObject aim, int power)
        {
            if (aim is Character character)
                character.Health += 10;
        }
        public override string ToString()
        {
            return "Маленькая бутылка живой воды";
        }
    }
}