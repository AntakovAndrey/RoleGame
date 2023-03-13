using Forms.Engine;
using RoleGame;

namespace Forms
{
    public partial class Form1 : Form
    {
        private Scene currentScene;
        private RadioButton[] genderRadioButtons;
        private RadioButton[] raceRadioButtons;
        private RadioButton[] stateRadioButtons;

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
        }

        public void updateCharactersList()
        {
            this.listBox1.Items.AddRange(this.currentScene.)
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