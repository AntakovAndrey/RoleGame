using System;

namespace RoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character("sf", characterState.normal, characterRace.human, characterGender.female);
            Console.Read();

        }
    }
}