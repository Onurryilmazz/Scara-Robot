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
            InverseKinematic ýnverseKinematic = new InverseKinematic();
            ýnverseKinematic.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForwardKýnematic forwardKýnematic = new ForwardKýnematic();
            forwardKýnematic.ShowDialog();
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