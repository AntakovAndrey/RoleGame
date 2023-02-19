using Forms.Engine;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Keys up = Keys.W; 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)up)
            {
                this.label1.Text += "w";
                KeysConfig kk = new KeysConfig(
                    Keys.W, Keys.S, Keys.A, Keys.D,
                    Keys.E, Keys.E, Keys.E, Keys.E, Keys.E, Keys.E,
                    Keys.Z, Keys.Z, Keys.Z, Keys.Z, Keys.Z, Keys.Z,
                    Keys.Tab
                );
                kk.SaveConfig();
            }
        }
    }
}