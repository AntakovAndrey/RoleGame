using System;
using System.Collections;
using System.Data.Common;

namespace RoleGame
{
    public enum characterState
    {
        normal,
        weak, 
        sick, 
        poisoned, 
        paralyzed, 
        dead
    }

    public enum characterRace
    {
        human,
        dwarf, 
        elf,
        orc, 
        goblin
    }
    
    public enum characterGender
    {
        male,
        female,
        none
    }

    internal class Character:IComparable<Character>
    {
        private int id;
        private string name;
        private characterState state;
        private bool isAbleToSpeak;
        private bool isAbleToMove;
        private characterRace race;
        private characterGender gender;
        private int age;
        private double health;
        private double maxHealth;
        private int experience;

        public Character(string name, characterState state, characterRace race, characterGender gender)
        {
            this.name = name;
            this.state = state;
            this.race = race;
            this.gender = gender;

            this.id = (this.name, this.state, this.race, this.gender).GetHashCode();
            System.Console.WriteLine(id);
        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public characterState State { get { return state; } set { state = value; } }
        public bool IsAbleToSpeak { get { return isAbleToSpeak; } }
        public bool IsAbleToMove { get { return isAbleToMove; } }
        public characterRace Race { get { return race; } }
        public int Age { get { return age; }set { age = value; } }
        public double Health { get { return health; }set { health = value; } }

        public int CompareTo(Character character)
        {
            return experience.CompareTo(character.experience);
        }
        
    }
}