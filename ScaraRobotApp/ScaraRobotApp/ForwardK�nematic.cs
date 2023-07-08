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
    public partial class ForwardKınematic : Form
    {
        public SerialPort myport;
        public ForwardKınematic()
        {
            InitializeComponent();
        }

        private void pageLoad(object sender, EventArgs e)
        {
            textBox7.Text = trackBar2.Value.ToString();
            textBox8.Text = trackBar1.Value.ToString();
            textBox10.Text = trackBar4.Value.ToString();
            textBox9.Text = trackBar3.Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = trackBar1.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox10.Text = trackBar4.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox9.Text = trackBar3.Value.ToString();
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar4.Value = Convert.ToInt16(textBox10.Text);
            }
            catch (Exception)
            {

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar3.Value = Convert.ToInt16(textBox9.Text);
            }
            catch (Exception)
            {

            }
        }

        private List<double> angleToLocation(int j1, int j2)
        {
            double theta1F;
            double theta2F;

            double L1 = 228;
            double L2 = 136.5;

            double x;
            double y;

            List<double> result = new List<double>();

            theta1F = j1 * Math.PI / 180;
            theta2F = j2 * Math.PI / 180;
            x = Math.Round(L1 * Math.Cos(theta1F) + L2 * Math.Cos(theta1F + theta2F), 3);
            y = Math.Round(L1 * Math.Sin(theta1F) + L2 * Math.Sin(theta1F + theta2F), 3);

            result.Add(x);
            result.Add(y);

            return result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "home";
            myport = new SerialPort("COM3", 9600);
            //myport.BaudRate = 115200;
            //myport.PortName = "COM3";
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

        private void button1_Click(object sender, EventArgs e)
        {


            int j1_pick = trackBar2.Value;
            int j2_pick = trackBar1.Value;
            int j1_place = trackBar4.Value;
            int j2_place = trackBar3.Value;

            List<double> pickResult = angleToLocation(j1_pick, j2_pick);
            List<double> placeResult = angleToLocation(j1_place, j2_place);

            String command = "start";

            String xLocaiton_pick = pickResult[0].ToString().Replace(",", ".");
            String yLocation_pick = pickResult[1].ToString().Replace(",", ".");
            String xLocaiton_place = placeResult[0].ToString().Replace(",", ".");
            String yLocation_place = placeResult[1].ToString().Replace(",", ".");

            String zPickLocation = textBox1.Text.Replace(",", ".");
            String zPlaceLocation = textBox2.Text.Replace(",", ".");

            String location = xLocaiton_pick + "," + yLocation_pick + "," + xLocaiton_place + "," + yLocation_place + "," + zPickLocation + "," + zPlaceLocation;

            myport = new SerialPort("COM3", 9600);
            myport.Open();
            myport.Write(command);
            Thread.Sleep(3500);
            myport.Write(location);
            Thread.Sleep(2000);
            String test = myport.ReadExisting();
            Thread.Sleep(3000);
            String test2 = myport.ReadExisting();
            myport.Close();
        }
    }
}
