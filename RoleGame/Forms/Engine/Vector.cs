using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Engine
{
    internal class Vector
    {
        int x;
        int y;
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get => x; }
        public int Y { get => y; }

        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y);
    }
}
