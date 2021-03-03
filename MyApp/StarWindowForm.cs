using System;
using System.Windows.Forms;
using WindowsFormsDll;
using ComPortParserDLL;
using DatabaseDLL;
using SketchUploaderDLL;

namespace MyApp
{
    public partial class Form1 : Form
    {
        private DatabaseForm dbform;
        private SketchUploaderForm1 _uploaderForm;
        private DatabaseForm dbForm;
        public Form1()
        {
            InitializeComponent();
            _uploaderForm = new SketchUploaderForm1();
            dbform = new DatabaseForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _uploaderForm.ShowDialog();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbform.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}