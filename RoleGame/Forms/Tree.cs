using Forms.Engine;
using RoleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public delegate void ThreadStart(List<Character> characters);
    public class Tree : IGameObject
    {

        private Vector currentPosition;
        private Vector size;
        private int health;
        public Tree(Vector currentPosition, Vector size,int health)
        {
            this.currentPosition = currentPosition;
            this.size = size;
            this.health=health;
        }
        public void /*Character*/ Damage(/*Character character,List<Character> characters*/)
        {
            ThreadStart threadStart;
            threadStart = Start;
            var start = new System.Threading.ThreadStart(threadStart/*Start*/);
            var thread = new System.Threading.Thread(start);
            thread.Start();
        }
        Vector IGameObject.Position { get => this.currentPosition; set => this.currentPosition = value; }
        Vector IGameObject.Size { get => this.size; set => this.size = value; }
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
        public void Start(List<Character> characters)
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
