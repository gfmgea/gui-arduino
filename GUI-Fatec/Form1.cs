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

namespace GUI_Fatec
{
    public partial class Form1 : Form
    {

        string bfRecebe = string.Empty;
        public delegate void Fdelegate(string a);

        bool invRD0 = true;
        bool invRD1 = true;
        bool invRD2 = true;
        bool invRD3 = true;
        bool invRD4 = true;
        bool invRD5 = true;
        bool invRD6 = true;
        bool invRD7 = true;

        bool pwm1, pwm2;
        int aux = 0, aux2 = 0;

        public Form1()
        {
            InitializeComponent();
            VarreCOMs();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bfRecebe = serialPort1.ReadExisting();
            this.BeginInvoke(new Fdelegate(recebe_serial), new object[] { bfRecebe });
        }

        public void recebe_serial(string a)
        {
            if (checkBoxReception.Checked)
            {
                textBoxReceber.Text += a;
            }

            if(checkBoxAN0.Checked)
            {
                textBoxAN0.Text += a;
            }
        }

        private void VarreCOMs()
        {
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "COM1";
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBoxBaud.Text = "9600";
            #endregion
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            else
            {
                serialPort1.PortName = cbBoxPort.Text;
                serialPort1.BaudRate = int.Parse(cbBoxBaud.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
            }
            try
            {
                serialPort1.Open();
                btConectar.Enabled = false;
                btDesconectar.Enabled = true;
                btSair.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxPort.Enabled = false;
                panelMessageConect.BackColor = Color.Green;
                lbStatusConect.Text = "Conectado";
            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta serial!");
                MessageBox.Show("Configure a porta COM e o Baud Rate no controle de conexão serial");
                btConectar.Enabled = true;
                btDesconectar.Enabled = false;
                btSair.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxPort.Enabled = true;
                panelMessageConect.BackColor = Color.Yellow;
                lbStatusConect.Text = "Aguardando conexão";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btConectar.Enabled = true;
                btDesconectar.Enabled = true;
                btSair.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxPort.Enabled = true;
                panelMessageConect.BackColor = Color.Yellow;
                lbStatusConect.Text = "Desconectado";
            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta serial!");
                MessageBox.Show("Configure a porta COM e o Baud Rate no controle de conexão serial");
                btConectar.Enabled = false;
                btDesconectar.Enabled = true;
                btSair.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxPort.Enabled = false;
                panelMessageConect.BackColor = Color.Green;
                lbStatusConect.Text = "Aguardando conexão";
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(textBoxEnviar.Text);
                textBoxEnviar.Text = "";
                textBoxEnviar.Focus();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btRD0_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true & invRD0 == true)
            {
                serialPort1.Write("a");
                labelRD0.Text = "L0-On";
                labelRD0.BackColor = Color.Aqua;
                invRD0 = false;
            }
            else if(serialPort1.IsOpen == true & invRD0 == false)
            {
                serialPort1.Write("a");
                labelRD0.Text = "L0-Off";
                labelRD0.BackColor = Color.Yellow;
                invRD0 = true;
            }
            if(serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD1 == true)
            {
                serialPort1.Write("b");
                labelRD1.Text = "L1-On";
                labelRD1.BackColor = Color.Aqua;
                invRD1 = false;
            }
            else if (serialPort1.IsOpen == true & invRD1 == false)
            {
                serialPort1.Write("b");
                labelRD1.Text = "L1-Off";
                labelRD1.BackColor = Color.Yellow;
                invRD1 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD2 == true)
            {
                serialPort1.Write("c");
                labelRD2.Text = "L2-On";
                labelRD2.BackColor = Color.Aqua;
                invRD2 = false;
            }
            else if (serialPort1.IsOpen == true & invRD2 == false)
            {
                serialPort1.Write("c");
                labelRD2.Text = "L1-Off";
                labelRD2.BackColor = Color.Yellow;
                invRD2 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD3 == true)
            {
                serialPort1.Write("d");
                labelRD3.Text = "L3-On";
                labelRD3.BackColor = Color.Aqua;
                invRD3 = false;
            }
            else if (serialPort1.IsOpen == true & invRD3 == false)
            {
                serialPort1.Write("d");
                labelRD3.Text = "L3-Off";
                labelRD3.BackColor = Color.Yellow;
                invRD3 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD4 == true)
            {
                serialPort1.Write("e");
                labelRD4.Text = "L4-On";
                labelRD4.BackColor = Color.Aqua;
                invRD4 = false;
            }
            else if (serialPort1.IsOpen == true & invRD4 == false)
            {
                serialPort1.Write("e");
                labelRD4.Text = "L4-Off";
                labelRD4.BackColor = Color.Yellow;
                invRD4 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD5 == true)
            {
                serialPort1.Write("f");
                labelRD5.Text = "L5-On";
                labelRD5.BackColor = Color.Aqua;
                invRD5 = false;
            }
            else if (serialPort1.IsOpen == true & invRD5 == false)
            {
                serialPort1.Write("f");
                labelRD5.Text = "L5-Off";
                labelRD5.BackColor = Color.Yellow;
                invRD5 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD6 == true)
            {
                serialPort1.Write("g");
                labelRD6.Text = "L6-On";
                labelRD6.BackColor = Color.Aqua;
                invRD6 = false;
            }
            else if (serialPort1.IsOpen == true & invRD6 == false)
            {
                serialPort1.Write("g");
                labelRD6.Text = "L6-Off";
                labelRD6.BackColor = Color.Yellow;
                invRD6 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void btRD7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invRD7 == true)
            {
                serialPort1.Write("h");
                labelRD7.Text = "L7-On";
                labelRD7.BackColor = Color.Aqua;
                invRD7 = false;
            }
            else if (serialPort1.IsOpen == true & invRD7 == false)
            {
                serialPort1.Write("h");
                labelRD7.Text = "L7-Off";
                labelRD7.BackColor = Color.Yellow;
                invRD7 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o controle de conexão serial");
            }
        }

        private void trackBarPWM1_Scroll(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                labelPWM1.Text = ((trackBarPWM1.Value * 10).ToString()) + "%";

                if(pwm1)
                {
                    if(trackBarPWM1.Value < 11)
                    {
                        if (trackBarPWM1.Value > aux)
                        {
                            serialPort1.WriteLine(("]"));
                            aux = trackBarPWM1.Value;
                        }

                        if (trackBarPWM1.Value < aux)
                        {
                            serialPort1.WriteLine((")"));
                            aux = trackBarPWM1.Value;
                        }
                    }
                        

                }
                
            }
                 
        }

        private void trackBarPWM2_Scroll(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                labelPWM2.Text = ((trackBarPWM2.Value * 10).ToString()) + "%";

                if (pwm2)
                {
                    if (trackBarPWM2.Value < 11)
                    {
                        if (trackBarPWM2.Value > aux)
                        {
                            serialPort1.WriteLine(("["));
                            aux = trackBarPWM2.Value;
                        }

                        if (trackBarPWM2.Value < aux)
                        {
                            serialPort1.WriteLine(("("));
                            aux = trackBarPWM2.Value;
                        }
                    }


                }

            }
        }

        private void checkBoxPWM1_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if(pwm1)
                {
                    pwm1 = false;
                    checkBoxPWM1.Text = "OFF";
                    serialPort1.WriteLine("<");
                    trackBarPWM1.Enabled = false;
                }
                else
                {
                    pwm1 = true;
                    checkBoxPWM1.Text = "ON";
                    serialPort1.WriteLine(">");
                    trackBarPWM1.Enabled = true;
                }
            }
        }

        private void checkBoxPWM2_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (pwm2)
                {
                    pwm2 = false;
                    checkBoxPWM2.Text = "OFF";
                    serialPort1.WriteLine("<");
                    trackBarPWM2.Enabled = false;
                }
                else
                {
                    pwm2 = true;
                    checkBoxPWM2.Text = "ON";
                    serialPort1.WriteLine(">");
                    trackBarPWM2.Enabled = true;
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btAN0_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.WriteLine("i");
                textBoxAN0.Text = "";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
