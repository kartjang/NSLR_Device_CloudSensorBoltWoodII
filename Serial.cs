using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CloudSensor_BoltWood.Form1;

namespace CloudSensor_BoltWood
{

    public class Serial
    {
        const string THAT = "Serial";
        SerialPort serialPort = new SerialPort();


        public delegate void OnPacketReceivedEventHandler(string recvData);
        public event OnPacketReceivedEventHandler OnPacketReceivedEvent;

        public delegate void OnConnectedEventHandler(bool value);
        public event OnConnectedEventHandler OnConnectedEvent;

        public delegate void OnErrorReceivedEventHandler(string value);
        public event OnErrorReceivedEventHandler OnErrorReceivedEvent;

        public event deleLogger Log;      



        public string port { get; set; }

        #region 생성자/소멸자
        public Serial()
        {
            serialPort.ReadTimeout  = 1000;
            serialPort.WriteTimeout = 1000;


        }

        public void OpenSerial(string sPort, string sBaudRate, string sDataBits, string sParity, string sStopBits)
        {
            try
            {
                if (sPort != null)
                {
                    if (serialPort.IsOpen) serialPort.Close();

                    serialPort.PortName = sPort;
                    serialPort.BaudRate = int.Parse(sBaudRate);

                    serialPort.DataBits = int.Parse(sDataBits);

                    //if (sStopBits == "1")
                    serialPort.StopBits = StopBits.One;

                    //if (sParity == "None")
                    serialPort.Parity = Parity.None;

                    serialPort.Handshake = Handshake.None;
                    serialPort.RtsEnable = true;

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    //serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);

                    serialPort.Open();

                    if (serialPort.IsOpen)
                    {
                        port = serialPort.PortName;
                        OnConnectedEvent?.Invoke(true);
                    }
                    else
                    {
                        port = null;
                        OnConnectedEvent?.Invoke(false);
                    }
                }
            }
            catch
            {
                OnConnectedEvent?.Invoke(false);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool bDisposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!bDisposed)
            {
                bDisposed = true;
                if (disposing)
                {
                    //관리되는 자원을 해제
                }
                //관리되지 않는 자원을 해제
                //큰 변수들을 null로 설정한다.

                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Debug.WriteLine("연결 해제");
                }
                OnConnectedEvent?.Invoke(false);
            }
        }

        ~Serial()
        {
            Dispose(false);
        }
        #endregion

        #region Handler
        public bool SendData(string sendData)
        {
            /*byte[] xbytes = new byte[sendData.Length / 2];
            for (int i = 0; i < xbytes.Length; i++)
            {
                xbytes[i] = Convert.ToByte(sendData.Substring(i * 2, 2), 16);
            }
            serialPort.Write(xbytes, 0, xbytes.Length);
            */
            try
            {
                serialPort.Write(sendData);
                return (true);
            }
            catch { return (false); }

        }



        byte[] packetBuffer = new byte[1024];
        int packetCount = 0;
        const byte STX = 0x7E;
        const byte ETX = 0xFE;

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = sender as SerialPort;


            // 수신 데이터 문자수 확인
            string strRecData = string.Empty;

            // 수신 버퍼의 값을 모두 읽어 온다.
            //strRecData = sp.ReadExisting();
            strRecData = serialPort.ReadLine();
            
            //Log(LOG.D, THAT, $"[ {strRecData} <-----  packet ] ");
            OnPacketReceivedEvent?.Invoke(strRecData);
            ClearRxState();
        }
        private void ClearRxState()
        {
            Array.Clear(packetBuffer, 0, packetBuffer.Length); // 버퍼 초기화
            packetCount = 0;
        }

        /*
        void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (ErrorReceived != null)
            {
                ErrorReceived(this, e);
            }
        }


        private void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SerialError serialError = e.EventType;
            string errorMessage = string.Empty;

            MessageBox.Show(errorMessage);

            switch (serialError)
            {
                case SerialError.Frame: errorMessage = "HardWare Framing Error"; break;
                case SerialError.Overrun: errorMessage = "Charaters Buffer Over Run"; break;
                case SerialError.RXOver: errorMessage = "Input Buffer OverFlow"; break;
                case SerialError.RXParity: errorMessage = "Founded Parity Error"; break;
                case SerialError.TXFull: errorMessage = "Write Buffer was Fulled"; break;
                default: break;
            }
            //OnErrorReceivedEvent(errorMessage);
        }
        */

        #endregion
    }
}
