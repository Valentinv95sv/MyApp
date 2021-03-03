using System;
using System.Drawing;
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


        public ComPort(string port, int baudrate)
        {
            this.port = port;
            this.baudrate = baudrate;
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
                message = "disconnect";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }

        public string getData()
        {
            return myport.ReadExisting().ToString();
        }
    }
}