using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;
using GUIHandlerDLL;

namespace MyApp
{
    public partial class DatabaseForm : Form
    {
        private GuiHandler _handler = new GuiHandler();
        private static System.Timers.Timer _timer;
        
        public DatabaseForm()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer(1000);
            _timer.AutoReset = true;
            _timer.Enabled = false;
            _timer.Elapsed += timer1_Elapsed;
            _handler.PortInit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _handler.DatabaseConnection(textBox2.Text.ToString(), textBox3.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            List<string> list = new List<string>();
            list = _handler.select();
            foreach (var i in list)
            {
                textBox1.AppendText(i);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            foreach (var i in _handler.selectLastFive())
            {
                textBox4.AppendText(i);
                textBox4.AppendText(Environment.NewLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _handler.delete();   
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            string a = _handler.dataFromArduino();
            _handler.insert(a);
            textBox4.AppendText(a);
            textBox4.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _handler.openCon();
            _timer.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _handler.closeCon();
            _timer.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _handler.deleteAll();
        }
    }
}