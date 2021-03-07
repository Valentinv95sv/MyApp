﻿using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;
using ComPortParserDLL;
using DatabaseDLL;
using SketchUploaderDLL;

namespace WindowsFormsDll
{
    public partial class WorkWithArduinoForm : Form
    {
        private DbClass _dbClass;
        private ComPort _comPort;
        private uploaderClass _uploader= new uploaderClass();
        private string[] ColumnName = {"C1", "C2", "C3"};

        public WorkWithArduinoForm()
        {
            InitializeComponent();
            Init();
            _dbClass = new DbClass();
            _comPort = new ComPort(comboBox1.Text , 9600);
            _comPort.timer_inint(timer1_Elapsed);
        }
        
        public void Init()
        {
            try
            {
                if (_uploader.getPorts().Length == 1)
                {
                    comboBox1.Text = _uploader.getPorts()[0];
                }

                foreach (var i in _uploader.getPorts())
                {
                    comboBox1.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            _dbClass.Connect(textBox2.Text.ToString(), textBox3.Text.ToString(), "MyDb");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            List<string> list = new List<string>();
            list = _dbClass.Select(ColumnName);
            foreach (var i in list)
            {
                textBox1.AppendText(i);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var i in _dbClass.selectLastFive(ColumnName))
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
            //string[] b = {"Data", "test"};
            string[] b = {"C1", "C2", "C3" };
            string[] a = _comPort.Split(_comPort.getData());
            _dbClass.Insert(a, b);
            //textBox4.AppendText(a[0] + " | " + a[1]);
            textBox4.AppendText(a[0] + " | " + a[1] + " | " + a[2]);
            textBox4.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            _comPort.ConnectToArduino();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _comPort.DisconnectFromArduino();
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