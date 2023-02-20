using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Engine
{
    internal class Render
    {
        static Vector resolution;
        static IScene scene;
        public static void SetResolution(int x, int y) => resolution = new Vector(x, y);
        public static void SetScene(IScene customScene) => scene = customScene;
        public static Image DrawFrame()
        {
            Bitmap bitmap = new Bitmap(resolution.X, resolution.Y);
            Graphics g = Graphics.FromImage(bitmap);
            scene.DrawBack(g, resolution.X, resolution.Y);
            scene.DrawObjects(g);
            return bitmap;
        }
        public static Vector Resolution => resolution;
    }
}