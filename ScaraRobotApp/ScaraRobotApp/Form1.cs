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
            InverseKinematic żnverseKinematic = new InverseKinematic();
            żnverseKinematic.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForwardKżnematic forwardKżnematic = new ForwardKżnematic();
            forwardKżnematic.ShowDialog();
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