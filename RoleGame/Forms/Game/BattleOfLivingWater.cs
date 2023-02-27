using System;
using RoleGame;

namespace Forms.Game
{
    internal class BattleOfLivingWater : Artefact
    {
        public void SmallBattleOfLivingWater(Character character)
        {
            character.Health += 10;
            Console.WriteLine("Здоровье персонажа увеличено на 10 едениц");
        }
        public void AvvarageBattleOfLivingWater(Character character)
        {
            character.Health += 25;
            Console.WriteLine("Здоровье персонажа увеличено на 25 едениц");
        }
        public void BigBattleOfLivingWater(Character character)
        {
            character.Health += 50;
            Console.WriteLine("Здоровье персонажа увеличено на 50 едениц");
        }
    }
}