using System;
using System.Windows.Forms;
using ArduinoUploader.Hardware;
using ComPortParserDLL;
using GUIHandlerDLL;
using SketchUploaderDLL;

namespace MyApp
{
    public partial class Form1 : Form
    {
        private myForm form;
        private DatabaseForm dbform;
        public Form1()
        {
            InitializeComponent();
            form = new myForm();
            dbform = new DatabaseForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowDialog();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbform.ShowDialog();
        }
        
        
        
    }
}