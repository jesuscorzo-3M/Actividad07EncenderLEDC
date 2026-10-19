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
using System.Security.Cryptography.X509Certificates;

namespace Actividad07EncenderLEDC
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM8";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
            this.FormClosing += CerrandoForm1;
            this.Btn_Apagar.Click += Btn_Apagar_Click;
            this.Btn_Encender.Click += Btn_Encender_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Encender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}
