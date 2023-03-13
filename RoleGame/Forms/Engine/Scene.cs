using Forms.Game;
using RoleGame;

namespace Forms.Engine
{
    internal class Scene:IScene
    {
        Image back;

        private KeysConfig config;

        private List<IGameObject> objects;
        private Tree tree; 

        private int playableCharacterIndex;
        private int aimIndex;

        public List<IGameObject> Objects
        { get=>Objects;}
        public KeysConfig Config { get { return config; } }

        public int PlayableCharacterIndex { get { return playableCharacterIndex; } set { playableCharacterIndex = value; } }
        public int AimIndex { get { return aimIndex; } set { aimIndex = value; } }
        

        public Scene()        
        {
            config = KeysConfig.LoadConfig();
            back = Image.FromFile("resources\\background.jpg");
            objects = new List<IGameObject>();
            Tree tree = new Tree(new Vector(500, 500), new Vector(100, 100), 100);
            
            addObject(new Character("Человек", characterState.normal, characterRace.dwarf, characterGender.male, new Vector(100, 100), new Vector(100, 100), new Inventory()));
            this.playableCharacterIndex = 0;
        }

        public void addObject(IGameObject gameObject)
        {
            this.objects.Add(gameObject);
        }

        public void DrawBack(Graphics g, int x, int y)
        {
            for(int i = 0; i < 1000; i+=back.Height)
            {
                for(int j=0;j<1000;j+=back.Width)
                {
                    g.DrawImageUnscaled(back, j, i, back.Width, back.Height);
                }
            }
        }

        public void DrawObjects(Graphics g)
        {
            tree.Draw(g);
            foreach(var obj in objects)
            {
                obj.Draw(g);
            }
        }

        public void movePlayableCharacter(Vector direction)
        {
            this.objects[this.playableCharacterIndex].Move(direction);
        }
    }
}