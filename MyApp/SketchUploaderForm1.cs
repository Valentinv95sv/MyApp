using System;
using System.Windows.Forms;
using SketchUploaderDLL;

namespace WindowsFormsDll
{
    public partial class SketchUploaderForm1 : Form
    {
        private uploaderClass _uploader= new uploaderClass();
        
        public SketchUploaderForm1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            try
            {
                comboBox1.Text = _uploader.getModelList()[5];
                foreach (var i in _uploader.getModelList())
                {
                    comboBox1.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (_uploader.getPorts().Length == 1)
                {
                    comboBox2.Text = _uploader.getPorts()[0];
                }

                foreach (var i in _uploader.getPorts())
                {
                    comboBox2.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _uploader.openfile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _uploader.uploadSketch(textBox1.Text.ToString(), model: _uploader.SetModel(comboBox1.Text.ToString()),
                    comboBox2.Text.ToString(), 9600);
                MessageBox.Show("Sketch download proccess is successful");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}