using System;
using System.Windows.Forms;
using ArduinoUploader.Hardware;
using ComPortParserDLL;
using SketchUploaderDLL;

namespace MyApp
{
    public partial class Form1 : Form
    {
        private string FileName = @"C:\Arduino\123\123.ino.eightanaloginputs.hex";
        private string PortName = "COM3";
        ArduinoModel model = ArduinoModel.NanoR3;
        private uploaderClass uploader;
        private ComPort comport;
        public Form1()
        {
            InitializeComponent();
            comport = new ComPort("COM3", 9600);
            uploader = new uploaderClass(FileName, PortName, model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uploader.upload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comport.getPorts();
        }
    }
}