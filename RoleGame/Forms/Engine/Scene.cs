using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Engine
{
    internal class Scene:IScene
    {
        KeysConfig keysConfig;

        private List<IGameObject> objects;

        public Scene()        {
            keysConfig = KeysConfig.LoadConfig();

        }

        public void DrawBack(Graphics g, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void DrawObjects(Graphics g)
        {
            
            throw new NotImplementedException();
        }
    }
}