using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Game
{
    public delegate void ThreadStart(List<Character> characters);
    public class Tree : IGameObject
    {

        private Vector currentPosition;
        private Vector size;
        private int health;
        private List<Character> characters;
        public Tree(Vector currentPosition, Vector size, int health)
        {
            this.currentPosition = currentPosition;
            this.size = size;
            this.health = health;
        }
        public void Damage()
        {
            ThreadStart threadStart;
            var start = new System.Threading.ThreadStart(Start);
            var thread = new Thread(start);
            thread.Start();
        }
        Vector IGameObject.Position { get => currentPosition; set => currentPosition = value; }
        Vector IGameObject.Size { get => size; set => size = value; }
        public void Draw2(Graphics graphics)
        {
            Image.FromFile("resources\\tree2.png");
        }

        public void Draw(Graphics graphics)
        {
            Image.FromFile("resources\\tree.png");
        }

        public void Move(Vector direction)
        {
            throw new NotImplementedException();
        }
        public void Start()
        {
            while (health > 0)
            {
                Random random = new Random();
                characters[random.Next(characters.Count)].Health -= 30;
                Thread.Sleep(300);
            }
        }
    }
}
