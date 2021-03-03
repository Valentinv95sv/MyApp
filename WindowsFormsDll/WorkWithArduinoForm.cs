using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;
using ComPortParserDLL;
using DatabaseDLL;
using ComPortParserDLL;

namespace WindowsFormsDll
{
    public partial class WorkWithArduinoForm : Form
    {
        private DbClass _dbClass;
        private ComPort comport;
        private static System.Timers.Timer _timer;
        private ComPort _comPort;
        
        public WorkWithArduinoForm()
        {
            InitializeComponent();
            _dbClass = new DbClass();
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += timer1_Elapsed;
            _comPort = new ComPort("COM4", 9600);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dbClass.Connect(textBox2.Text.ToString(), textBox3.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            List<string> list = new List<string>();
            list = _dbClass.Select();
            foreach (var i in list)
            {
                textBox1.AppendText(i);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var i in _dbClass.selectLastFive())
            {
                textBox1.AppendText(i);
                textBox1.AppendText(Environment.NewLine);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _dbClass.Delete();   
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] b = {"Data", "test"};
            string[] a = _comPort.Split(_comPort.getData());
            _dbClass.Insert(a, b);
            textBox4.AppendText(a[0] + " | " + a[1]);
            textBox4.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            _comPort.ConnectToArduino();
            _timer.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _comPort.DisconnectFromArduino();
            _timer.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _dbClass.deleteAll();
        }
        
    }
}