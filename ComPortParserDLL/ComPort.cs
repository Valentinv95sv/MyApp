using System;
using System.IO.Ports;
using System.Windows.Forms;


namespace ComPortParserDLL
{
    public class ComPort
    {
        Boolean isConnected;
        private string port { get; set; }
        private int baudrate { get; set; }
        SerialPort myport = new SerialPort();
        private static System.Timers.Timer _timer;


        public ComPort(string port, int baudrate)
        {
            this.port = port;
            this.baudrate = baudrate;
        }

        public void timer_inint(System.Timers.ElapsedEventHandler action)
        {
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += action;
        }
        

        public string[] getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                MessageBox.Show("Com port not found");
            }
            return ports;
        }

        public void ConnectToArduino()
        {
            try
            {
                isConnected = true;
                myport.PortName = port;
                myport.BaudRate = baudrate;
                myport.Open();
                _timer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisconnectFromArduino()
        {
            try
            {
                isConnected = false;
                myport.Close();
                _timer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getData()
        {
            return myport.ReadExisting();
        }

        public void Write(string income)
        {
            if (myport.IsOpen == true)
            {
                myport.Write(income);
            }
            else
            {
                myport.Open();
                myport.Write(income);
            }
            
        }
        
        public void InBuffClear()
        {
            myport.DiscardInBuffer();
        }

        public void OutBuffClear()
        {
            myport.DiscardOutBuffer();
        }

        public int BufferSize()
        {
            return myport.ReadBufferSize;
        }

        public string[] Split(string list)
        {
            string[] separator = {"/", ",", ";"};
            string[] a = list.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return a;
        }

        //деление входящей строки по датчикам
        public string[]  DataDetection(string income)
        {
            //example string
            string example= "13%/24.3 град/ 1002 свет/ 0.1 ДБ";
            
            string[] Meteodata = new string[2];
            string LightData = "";
            string SoundData = "";

            string[] separator = {"/", ",", ";"};
            //string income = myport.ReadExisting(); 
            //string[] query = income.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] query = example.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (var i in query)
            {
                if(i.Contains("град"))
                {
                    Meteodata[0] = i;
                }

                if (i.Contains("%"))
                {
                    Meteodata[1] = i;
                }

                if (i.Contains("свет"))
                {
                    LightData = i;
                }

                if (i.Contains("ДБ"))
                {
                    SoundData = i;
                }
            }

            string[] a = new[] {Meteodata[0], Meteodata[1], LightData, SoundData };
            return a;
        }
        
    }
}