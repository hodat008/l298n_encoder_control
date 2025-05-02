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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;

namespace BTL_do_luong_cn
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = {"2400","9600","115200"};
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboBaudrate.Text = "9600";
            cboCOM.DataSource = SerialPort.GetPortNames();
        }

        private void BttConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serCOM.PortName = cboCOM.Text;
                serCOM.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                serCOM.Open();
                if (serCOM.IsOpen)
                {
                    lbState.Text = "Connected";
                    lbState.ForeColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("Invalid COM");
            }
        }

        private void BttDisconnect_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            if(!serCOM.IsOpen)
            {
                lbState.Text = "Disconnected";
                lbState.ForeColor = Color.Red;
            }
        }

        private void BttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Data = "";
            Data = serCOM.ReadLine();
            textBox_Angle_real.Text = Data;
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not opened");
            }
            else
            {
                if (int.TryParse(textBoxAngle.Text.Trim(), out int angle))
                {
                    serCOM.WriteLine(angle.ToString()); // Gửi có \n
                }
                else
                {
                    MessageBox.Show("Please rewrite int value");
                }
                if (angle > 0)
                {
                    label_rotate.Text = "Right";
                    label_rotate.ForeColor = Color.Green;
                }
                if (angle < 0)
                {
                    label_rotate.Text = "Left";
                    label_rotate.ForeColor = Color.Green;
                }
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            label_state.Text = "Stop";
            label_state.ForeColor = Color.Red;
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not oppened");
            }
            else
            {
                label_rotate.Text = "None";
                label_rotate.ForeColor = Color.Red;
                string dulieu = "stop\n";
                serCOM.Write(dulieu);
            }
        }

        private void textBox_Angle_real_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAngle.Text == textBox_Angle_real.Text)
            {
                label_state.Text = "Stop";
                label_state.ForeColor = Color.Red;
            }
            if (textBoxAngle.Text == "")
            {
                label_state.Text = "Stop";
                label_state.ForeColor = Color.Red;
            }
        }

        private void butSend_2_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not oppened");
            }
            else
            {
                string pulse = textBoxAngle.Text;
                serCOM.Write(pulse);
            }
        }

        private void button_rotate_left_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not oppened");
            }
            else
            {
                label_state.Text = "Start";
                label_state.ForeColor = Color.Green;
                label_rotate.Text = "Left";
                label_rotate.ForeColor = Color.Green;
                string dulieu = "rotate_left\n";
                serCOM.Write(dulieu);
            }
        }

        private void button_rotate_right_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not oppened");
            }
            else
            {
                label_state.Text = "Start";
                label_state.ForeColor = Color.Green;
                label_rotate.Text = "Right";
                label_rotate.ForeColor = Color.Green;
                string dulieu = "rotate_right\n";
                serCOM.Write(dulieu);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            label_state.Text = "Reseted";
            label_state.ForeColor = Color.Red;
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("COM is not oppened");
            }
            else
            {
                label_rotate.Text = "None";
                label_rotate.ForeColor = Color.Red;
                string dulieu = "reset\n";
                serCOM.Write(dulieu);
            }
        }
    }
}
