namespace ScaraRobotApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InverseKinematic �nverseKinematic = new InverseKinematic();
            �nverseKinematic.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForwardK�nematic forwardK�nematic = new ForwardK�nematic();
            forwardK�nematic.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FreeControl freeControl = new FreeControl();
            freeControl.ShowDialog();
            this.Show();
        }
    }
}