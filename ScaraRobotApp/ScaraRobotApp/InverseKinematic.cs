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

namespace ScaraRobotApp
{
    public partial class InverseKinematic : Form
    {
        public SerialPort myport;
        public InverseKinematic()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
            String command = "start";
            String xLocaiton_pick = textBox1.Text.Replace(",", ".");
            String yLocation_pick = textBox2.Text.Replace(",", ".");
            String xLocaiton_place = textBox6.Text.Replace(",", ".");
            String yLocation_place = textBox5.Text.Replace(",", ".");

            String zPickLocation = textBox3.Text.Replace(",", ".");
            String zPlaceLocation = textBox4.Text.Replace(",", ".");

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
