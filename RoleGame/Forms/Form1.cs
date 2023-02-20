using Forms.Engine;

namespace Forms
{
    public partial class Form1 : Form
    {
        Scene scene;
        Vector resolution;
        public Form1()
        {
            InitializeComponent();
            resolution = new Vector(1000, 1000);
            Render.SetResolution(resolution.X,resolution.Y);
            this.Width=resolution.X;
            this.Height=resolution.Y;
            this.pictureBox1.Width = resolution.X;
            this.pictureBox1.Height = resolution.Y;
        }

        KeysConfig config = KeysConfig.LoadConfig(); 

        Render render;
       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
            //if (e.KeyValue == (char)config.KeyUp)
            //{
            //    MessageBox.Show(config.KeyUp.ToString());
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Render.DrawFrame();
        }
    }
}