using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CloudSensor_BoltWood.Serial;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CloudSensor_BoltWood
{
    public partial class Form1 : Form
    {
        public delegate void deleLogger(LOG level, object sender, string strLog);

        Serial cSerial;
        bool isSerialOpen = false;
        string ComPort = "";
        string Data2Send = "G OC ALL";

        int D_CLOUD = 2;
        int D_DEWPT = 3;
        int D_HUMID = 4;
        int D_PRESS = 5;
        int D_RAINR = 6;
        int D_SKY_BRGT = 7;
        int D_SKY_AMBI = 9;
        int D_AMBI = 11;
        int D_WIND = 14;

        // 구조체 정의
        struct MyPoint
        {
            public int X;
            public int Y;
            public MyPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1})", X, Y);
            }

        }



        public Form1()
        {
            InitializeComponent();

            prepare_interface();
            timer1.Interval = Convert.ToInt32(2500);

            textBox_Ambi.MouseWheel += new MouseEventHandler(textBox_Ambi_MouseWheel);


            //MyPoint.X = 1;


        }

        private void textBox_Ambi_MouseWheel(object sender, MouseEventArgs e)
        {
            int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            PictureBox pb = (PictureBox)sender;

            if (lines > 0)
            {
                
            }
            else if (lines < 0)
            {
                
            }

            pictureBox1.Invalidate();
        }






        private void prepare_interface()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_port.Items.Clear();
            foreach (string comport in ports)
            {
                comboBox_port.Items.Add(comport);
            }
            
            if (ConfigurationManager.AppSettings["Comport"].StartsWith("COM") )
            {
                ComPort = ConfigurationManager.AppSettings["Comport"];
                comboBox_port.SelectedIndex = comboBox_port.Items.IndexOf(ComPort);
                CreatesInterface(ComPort);
            }                
        }


        private void CreatesInterface(string com_port)
        {
            if (cSerial != null)
            {
                cSerial.Dispose();
            }

            cSerial = new Serial();
            cSerial.OnPacketReceivedEvent += OnPacketReceivedEvent;
            cSerial.OnErrorReceivedEvent += OnSerialErrorReceived;
            cSerial.OnConnectedEvent += ChangeConnected;
            cSerial.Log += Logger;
 
            cSerial.OpenSerial(com_port, textBox_baudRate.Text, textBox_DataBits.Text, textBox_Parity.Text, textBox_Stop.Text);
            //cSerial.OpenSerial("COM7",  "9600", textBox_DataBits.Text, textBox_Parity.Text, textBox_Stop.Text);
        }

        private void ChangeConnected(bool bCon)
        {
            if (bCon)
            {
                this.label5.ForeColor = System.Drawing.Color.Lime;
                isSerialOpen = true;
                                
            }
            else
            {
                this.label5.ForeColor = System.Drawing.Color.Red;
                isSerialOpen = false;
                timer1.Enabled = false;
                Log(LOG.I, $"\t\t\t\t\t\t (xx) DisConnnection (xx) {comboBox_port.SelectedItem.ToString()}" );
            }         
        }


        string ORDER = Environment.NewLine + Environment.NewLine;
        private void OnPacketReceivedEvent(string recvData)
        {
            Log(LOG.D, recvData);
            string[] parser = recvData.Split('\x020');

            foreach (var word in parser)
                Log(LOG.I , word);           

            textBox_Cloud.Text = ORDER + parser[D_CLOUD];
            textBox_SkyAmbi.Text = ORDER + parser[D_SKY_AMBI];
            textBox_Ambi.Text = ORDER + parser[D_AMBI];
            textBox_Rain.Text = ORDER + parser[D_RAINR];
            textBox_Press.Text = ORDER + parser[D_PRESS];
            textBox_Humid.Text = ORDER + parser[D_HUMID];
            textBox_DewP.Text = ORDER + parser[D_DEWPT];    
            textBox_wind.Text = ORDER + parser[D_WIND];
            textBox1_SkyBrt.Text = ORDER + parser[D_SKY_BRGT];

            ConfigurationManager.AppSettings["Comport"] = comboBox_port.SelectedItem.ToString();
            Log(LOG.I, $"(oo) Connnected (oo) {comboBox_port.SelectedItem.ToString()}  {ConfigurationManager.AppSettings["Comport"]}");
            ComPort = cSerial.port;
        }

        private void OnSerialErrorReceived(string error)
        {
            Log(LOG.D, $"[error] {error}");
        }



        #region UI Control
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cSerial != null)   cSerial.Dispose();
        }
        #endregion

        #region Log OverLoading   /////////////////////////////////////////////////////////////////////////////
        // Log Level을 지정 할 Enum
        public enum LOG
        {
            I, //INFO
            W, //WARN
            D, //DEBUG
            E, //ERROR
            F, //FATAL
        }
        private void Logger(LOG eLevel, object sender, string strLog)
        {
            Log(eLevel, strLog);
        }
        private void Log(LOG eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;
            string LogInfo = $" {dTime:yyyy-MM-dd hh:mm:ss.fff}   {eLevel.ToString()}   {LogDesc}";
            listBox1.Items.Insert(listBox1.Items.Count, LogInfo);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

        }
        private void Log(DateTime dTime, LOG eLevel, string LogDesc)
        {
            string LogInfo = $" {dTime:yyyy-MM-dd hh:mm:ss.fff}  [{eLevel.ToString()}]   {LogDesc}";
            listBox1.Items.Insert(0, LogInfo);
        }
        #endregion  //////////////////////////////////////////////////////////////////////////////////////


        /* No Response Check
        Log(LOG.D, $"no_rsp_cnt {no_rsp_cnt}");
                if (no_rsp_cnt++ > 2) 
                {
                    timer1.Enabled = false;
                    checkBox_RunStop.Text = "Run";
                    checkBox_RunStop.Checked = false;
                }
        */


    private void comboBox_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatesInterface(comboBox_port.SelectedItem.ToString());
        }

        private void button_LogClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        int no_rsp_cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {           

            if (isSerialOpen)
            {
                cSerial.SendData(Data2Send);
            }
            // Log(LOG.D, "timer_tick");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (isSerialOpen)
            {
                if (checkBox_RunStop.Checked)
                {
                    timer1.Enabled = true;
                    //Log(LOG.D, "rb_check  T");
                    checkBox_RunStop.Text = "Stop";
                    no_rsp_cnt = 0;
                }
                else
                {
                    timer1.Enabled = false;
                    //Log(LOG.D, "rb_check  F");
                    checkBox_RunStop.Text = "Run";
                }
            }
            else
            {
                MessageBox.Show("Serial Port를 먼저 Open해 주세요"); 
            }
        }


    }
}
