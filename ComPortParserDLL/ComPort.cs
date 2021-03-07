using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ComPortParserDLL
{
    public class ComPort
    {
        Boolean isConnected;
        private string port { get; set; }
        private int baudrate { get; set; }
        private string message;
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
                message = "connectes";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }

        public void DisconnectFromArduino()
        {
            try
            {
                isConnected = false;
                myport.Close();
                _timer.Enabled = false;
                message = "disconnect";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }

        public string getData()
        {
            return myport.ReadExisting();
        }

        public string[] Split(string list)
        {
            string[] separator = {"/", ",", ";"};
            string[] a = list.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return a;
        }
    }
}