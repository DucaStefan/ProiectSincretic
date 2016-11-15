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

namespace ArduinoSerial
{
    public partial class Form1 : Form
    {
          

        public object RichTextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += serialPort1_DataReceived;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            serialPort1.Open();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1"); //send 1 to Arduino
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0"); //send 0 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
          //  data = serialPort1.ReadLine();

            SerialPort sp = (SerialPort)sender;
            textBox1.Text += sp.ReadExisting() + "\n";
           // this.Invoke(new EventHandler(afisareData) );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
