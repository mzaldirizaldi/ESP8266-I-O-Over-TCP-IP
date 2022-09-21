using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace TCPIP_ESP8266
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        string DataIn;
        sbyte indexOfA;
        string potentio;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += potentio_DataReceived;
            DataIn = "";

        }

        private void potentio_DataReceived(object sender, SimpleTCP.Message e)
        {
            label_potentioInput.Invoke((MethodInvoker)delegate ()
           {
               DataIn = e.MessageString;
                   indexOfA = Convert.ToSByte(DataIn.IndexOf("A"));
                   potentio = DataIn.Substring(0, indexOfA);
                   label_potentioInput.Text = potentio;
                   progressBar_potentio.Value = Convert.ToInt32(potentio);
           });
        }

        private void button_connect_Click(object sender, EventArgs e)
        {

            client.Connect(textBox_ipAddress.Text, Convert.ToInt32(textBox_port.Text));
            button_connect.Enabled = false;
            progressBar_connect.Value = 100;

        }

        private void button_led1On_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("ON1#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_led1Off_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("OFF1#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_led2On_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("ON2#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_led2Off_Click(object sender, EventArgs e)
        {
            try
            {
                client.Write("OFF2#");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
