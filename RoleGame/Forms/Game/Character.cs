using Forms.Engine;
using Forms.Game;
using System;
using System.Security.Cryptography;

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
        female
    }

    public class Character:IComparable<Character>,IGameObject
    {
        public int CurrentAimIndex { get; set; }


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

        private Image characterImage;
        private Vector currentPosition;
        private Vector size;
        private Inventory inventory;
        public Character(string name, characterState state, characterRace race, characterGender gender,Vector startPosition, Vector size, Inventory inventory)
        {
            this.name = name;
            this.state = state;
            this.race = race;
            this.gender = gender;

            this.id = (this.name, this.state, this.race, this.gender).GetHashCode();

            this.characterImage = this.LoadImage(race);
            this.currentPosition = startPosition;
            this.size = size;
            this.inventory = inventory;
        }
        public void PerfomDamage(IGameObject aim)
        {
            if (aim is Character character)
                character.health -= 10;
            if(aim is Tree tree)
                tree.Health -= 15;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public characterState State { get { return state; } set { state = value; } }
        public bool IsAbleToSpeak { get { return isAbleToSpeak; } }
        public bool IsAbleToMove { get { return isAbleToMove; } }
        public characterRace Race { get { return race; } }

        public int Age { get { return age; } set { age = value; } }
        public double Health { 
            get { return health; }
            set {
                if (value < 0)
                    health = 0;
                else if (value > maxHealth)
                    health = 100;
                else
                    health = value; 
            } 
        }
        public double MaxHealth
        {
            get { return maxHealth; }
        }
        public int Experience
        {
            get { return experience; }
        }
        public Inventory Inventory
        { get => inventory; set => inventory = value; }
        private Image LoadImage(characterRace race)
        {
            switch (race)
            {
                case characterRace.human:
                    return Image.FromFile("resources\\human.png");
                case characterRace.dwarf:
                    return Image.FromFile("resources\\dwarf.png");
                case characterRace.elf:
                    return Image.FromFile("resources\\elf.png");
                case characterRace.orc:
                    return Image.FromFile("resources\\orc.png");
                case characterRace.goblin:
                    return Image.FromFile("resources\\goblin.png");
                default:
                    return Image.FromFile("resources\\human.png");
            }
        }

        public void Move(Vector vector)
        {
            this.currentPosition += vector;
        }

        public int CompareTo(Character character)
        {
            return experience.CompareTo(character.experience);
        }

        Vector IGameObject.Position { get => this.currentPosition; set => this.currentPosition=value; }
        Vector IGameObject.Size { get => this.size; set => this.size=value; }

        public void Draw(Graphics graphics)
        {   
            graphics.DrawImage(this.characterImage,this.currentPosition.X,this.currentPosition.Y,this.size.X,this.size.Y);
        }
        public override string ToString()
        {
            return $"Имя {name}, Жизнь {Health}";
        }
    }
}