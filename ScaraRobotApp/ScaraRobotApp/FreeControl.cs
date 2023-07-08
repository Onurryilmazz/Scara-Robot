using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScaraRobotApp
{
    public partial class FreeControl : Form
    {
        public SerialPort myport;
        public FreeControl()
        {
            InitializeComponent();
        }

        private void pageLoad(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "home";
            myport = new SerialPort("COM3", 9600);
            myport.Open();
            myport.Write(str);
            String test = myport.ReadExisting();
            myport.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String command = "stop";

            myport = new SerialPort("COM3", 9600);
            myport.Open();
            myport.Write(command);
            myport.Close();
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = trackBar1.Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar2.Value = Convert.ToInt16(textBox7.Text);
            }
            catch (Exception)
            {

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = Convert.ToInt16(textBox8.Text);
            }
            catch (Exception)
            {

            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar3.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar3.Value = Convert.ToInt16(textBox1.Text);
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runCommand(textBox7.Text, "1");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            runCommand(textBox8.Text, "2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            runCommand(textBox1.Text, "3");
        }

        private void runCommand(string location, string jointName)
        {
            String command = "run";

            String locationComman = location + "," + jointName;

            myport = new SerialPort("COM3", 9600);
            myport.Open();
            myport.Write(command);
            Thread.Sleep(3500);
            myport.Write(location);
            myport.Close();
        }
    }
}
