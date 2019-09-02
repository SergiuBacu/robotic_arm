using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TryServoControl
{
    public partial class Form1 : Form
    {
        SerialPort Port;
        public Form1()
        {
            InitializeComponent();
        }
//------------------------SendServoInfo---------------------------
        private void SendServoInfo(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString()+'*';

            try
            {

                Port.Write(message);

            }
            catch
            {

            }

        }
        //------------------------------------------------------------

        private void ResetServos()
        {
            int Position = 0;
            trackBar1.Value = Position;
            trackBar2.Value = Position;
            trackBar3.Value = Position;
            trackBar4.Value = Position;
            
            label7.Text =   Position.ToString();
            label8.Text = Position.ToString();
            label9.Text = Position.ToString();
            label10.Text = Position.ToString();
            label11.Text = Position.ToString();
            label12.Text = Position.ToString();

            for (int i = 0; i < 4; i++)
                SendServoInfo(i, Position);

                    }
        private void init()
    {
      Port = new SerialPort();
         Port.PortName = "COM3";
         Port.BaudRate = 9600;
         try
         {
             Port.Open();
         }
            catch(Exception e)
         {
             MessageBox.Show(e.Message);
         }
         ResetServos();
       
      
    }
        string s;
        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "SERVO1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;
            trackBar5.Value = 0;
            trackBar6.Value = 0;

            label7.Text = Convert.ToString(trackBar1.Value);
            label9.Text = Convert.ToString(trackBar3.Value);
            label8.Text = Convert.ToString(trackBar2.Value);
            label10.Text = Convert.ToString(trackBar4.Value);
            label11.Text = Convert.ToString(trackBar5.Value);
            label12.Text = Convert.ToString(trackBar6.Value);

            ResetServos();



        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         //   this.Activate = 
            label7.Text = Convert.ToString(trackBar1.Value);

            int servoPos = trackBar1.Value;
            if (Port.IsOpen)
            {
                label7.Text = "Position" + servoPos.ToString();
                SendServoInfo(1, servoPos);
            }

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(trackBar3.Value);

            int servoPos = trackBar3.Value;
            if (Port.IsOpen)
            {
                label9.Text = "Position" + servoPos.ToString();
                SendServoInfo(3, servoPos);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(trackBar2.Value);

            int servoPos = trackBar2.Value;
            if (Port.IsOpen)
            {
                label8.Text = "Position" + servoPos.ToString();
                SendServoInfo(2, servoPos);
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(trackBar4.Value);

            int servoPos = trackBar4.Value;
            if (Port.IsOpen)
            {
                label10.Text = "Position" + servoPos.ToString();
                SendServoInfo(4, servoPos);
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label11.Text = Convert.ToString(trackBar5.Value);

            int servoPos = trackBar5.Value;
            if (Port.IsOpen)
            {
                label11.Text = "Position" + servoPos.ToString();
                SendServoInfo(5, servoPos);
            }
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString(trackBar6.Value);

            int servoPos = trackBar6.Value;
            if (Port.IsOpen)
            {
                label12.Text = "Position" + servoPos.ToString();
                SendServoInfo(6, servoPos);
            }
        }


        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ResetServos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;;
            trackBar3.Enabled = false;
            trackBar4.Enabled = false;
            trackBar5.Enabled = false;
            trackBar6.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
            trackBar4.Enabled = true;
            trackBar5.Enabled = true;
            trackBar6.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
