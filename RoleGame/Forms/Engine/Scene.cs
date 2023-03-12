using RoleGame;

namespace Forms.Engine
{
    internal class Scene:IScene
    {
        Image back;
        
        private KeysConfig config = KeysConfig.LoadConfig();

        private List<IGameObject> objects;

        private int playableCharacterIndex;


        public Scene()        
        {
            KeysConfig.RestartConfig();
            back = Image.FromFile("resources\\background.jpg");
            objects = new List<IGameObject>();
            
            addObject(new Character("Человек", characterState.normal, characterRace.dwarf, characterGender.male, new Vector(100, 100), new Vector(100, 100), new Inventory()));
            this.playableCharacterIndex = 0;
        }

        public KeysConfig Config { get { return config; } }

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