using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace DatabaseDLL
{
    public partial class DatabaseForm : Form
    {
        private DbClass _dbClass;
        private static System.Timers.Timer _timer;
        
        
        public DatabaseForm()
        {
            InitializeComponent();
            _dbClass = new DbClass();
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
            textBox4.Clear();
            foreach (var i in _dbClass.selectLastFive())
            {
                textBox4.AppendText(i);
                textBox4.AppendText(Environment.NewLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _dbClass.Delete();   
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            string a = "asd";//_dbClass.dataFromArduino();
            _dbClass.Insert(a);
            textBox4.AppendText(a);
            textBox4.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _dbClass.OpenConnection();
            _timer.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _dbClass.CloseConnection();
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