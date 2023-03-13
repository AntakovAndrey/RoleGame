using Forms.Engine;
using Forms.Game.Artefacts;
using Forms.Game.Artefacts.BasiliskEye;
using Forms.Game.Artefacts.BattleOfLivingWater;
using Forms.Game.Artefacts.BottleOfLivingWater;
using Forms.Game.Artefacts.Decoct;
using Forms.Game.Artefacts.LightningStaff;
using RoleGame;
using RoleGame.Magic;

namespace Forms
{
    public partial class Form1 : Form
    {
        private Scene currentScene;
        private RadioButton[] genderRadioButtons;
        private RadioButton[] raceRadioButtons;
        private RadioButton[] stateRadioButtons;
        private Artefact[] allArtefacts;

        
        public Form1()
        {
            InitializeComponent();
            this.currentScene = new Scene();
            Render.SetResolution(1000, 1000);
            Render.SetScene(currentScene);

            genderRadioButtons = new RadioButton[]
            {
                this.radioButton1,
                this.radioButton2
            };
            raceRadioButtons = new RadioButton[]
            {
                this.radioButton3,
                this.radioButton4,
                this.radioButton5,
                this.radioButton6,
                this.radioButton7
            };
            stateRadioButtons = new RadioButton[]
            {
                this.radioButton8,
                this.radioButton9,
                this.radioButton10,
                this.radioButton11,
                this.radioButton12,
                this.radioButton13
            };
            

            updateCurrentMagicsList();
        }

        public void updateCurrentMagicsList()
        {
            if (this.currentScene.Objects[currentScene.PlayableCharacterIndex] is CharacterMag mag)
                this.listBox3.Items.AddRange(mag.Magics.ToArray());
        }

        public void updateAllMagicsList()
        {
            if (this.currentScene.Objects[currentScene.PlayableCharacterIndex] is CharacterMag mag)
            {
                IMagic[] allMagics = new IMagic[]
                {
                    new AddHealth(mag),
                    new Alive(mag),
                    new AniPoison(mag),
                    new Heal(mag),
                    new Otomri(mag)
                };
                this.listBox4.Items.AddRange(allMagics);
            }
        }

        public void updateAllArtefactsList()
        {
            if (this.currentScene.Objects[currentScene.PlayableCharacterIndex] is CharacterMag mag)
            {
                Artefact[] allArtefacts = new Artefact[]
                {
                    new SmallBattleOfLivingWater(),
                    new AvvarageBattleOfLivingWater(),
                    new BigBattleOfLivingWater(),
                    new BasiliskEye(),
                    new SmallBottleOfDeadWater(),
                    new AvvarageBattleOfDeadWater(),
                    new BigBattleOfDeadWater(),
                    new Decoct(),
                    new LightningStaff()
                };
                this.listBox6.Items.AddRange(allArtefacts);
            }
        }
        public void ListArtefact()
        {
            List<Artefact> artefacts = new List<Artefact>();
            if(this.currentScene.Objects[this.currentScene.PlayableCharacterIndex] is Character character)
                foreach(var cell in character.Inventory.Cells)
                    artefacts.Add(cell.Cell);
            this.listBox5.Items.AddRange(artefacts.ToArray());

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyValue==(char)currentScene.Config.KeyUp)
                this.currentScene.movePlayableCharacter(new Vector(0,-10));
            if (e.KeyValue == (char)currentScene.Config.KeyDown)
                this.currentScene.movePlayableCharacter(new Vector(0, 10));
            if (e.KeyValue == (char)currentScene.Config.KeyLeft)
                this.currentScene.movePlayableCharacter(new Vector(-10, 0));
            if (e.KeyValue == (char)currentScene.Config.KeyRight)
                this.currentScene.movePlayableCharacter(new Vector(10, 0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = Render.DrawFrame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int xPos = Convert.ToInt32(this.textBox2.Text);
            int yPos = Convert.ToInt32(this.textBox3.Text);
            characterGender gender = (characterGender)Array.IndexOf(genderRadioButtons, genderRadioButtons.FirstOrDefault(x => x.Checked == true));
            characterRace race = (characterRace)Array.IndexOf(raceRadioButtons, raceRadioButtons.FirstOrDefault(x => x.Checked == true));
            characterState state = (characterState)Array.IndexOf(stateRadioButtons, stateRadioButtons.FirstOrDefault(x => x.Checked == true));
            this.currentScene.addObject(new Character(name, state,race, gender, new Vector(xPos, yPos), new Vector(100, 100),new Inventory()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int xPos = Convert.ToInt32(this.textBox2.Text);
            int yPos = Convert.ToInt32(this.textBox3.Text);
            characterGender gender = (characterGender)Array.IndexOf(genderRadioButtons, genderRadioButtons.FirstOrDefault(x => x.Checked == true));
            characterRace race = (characterRace)Array.IndexOf(raceRadioButtons, raceRadioButtons.FirstOrDefault(x => x.Checked == true));
            characterState state = (characterState)Array.IndexOf(stateRadioButtons, stateRadioButtons.FirstOrDefault(x => x.Checked == true));
            this.currentScene.addObject(new Character(name, state, race, gender, new Vector(xPos, yPos), new Vector(100, 100), new Inventory()));
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.currentScene.PlayableCharacterIndex=this.listBox1.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.currentScene.PlayableCharacterIndex = this.listBox1.SelectedIndex;
        }
    }
}