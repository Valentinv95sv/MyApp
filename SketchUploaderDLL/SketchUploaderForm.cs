using System;
using System.Windows.Forms;

namespace SketchUploaderDLL
{
    public partial class SketchUploaderForm : Form
    {

        private uploaderClass _uploaderClass = new uploaderClass();
        public SketchUploaderForm()
        {
            InitializeComponent();
            init();
        }

        
        
        public void init()
        {
            try
            {
                comboBox1.Text = _uploaderClass.getModelList()[5];
                foreach (var i in _uploaderClass.getModelList())
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
                if (_uploaderClass.getPorts().Length == 1)
                {
                    comboBox2.Text = _uploaderClass.getPorts()[0];
                }
                
                foreach (var i in _uploaderClass.getPorts())
                {
                    comboBox2.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _uploaderClass.openfile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _uploaderClass.uploadSketch(textBox1.Text.ToString(), model: _uploaderClass.SetModel(comboBox1.SelectedItem.ToString()),
                    comboBox2.SelectedItem.ToString(), 9600);
                MessageBox.Show("Sketch download proccess is successful");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
    }
}