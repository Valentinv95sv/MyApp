using System;
using System.Drawing;
using System.Windows.Forms;
using ComPortParserDLL;
using MyApp;
using SketchUploaderDLL;

namespace WindowsFormsDll
{
    public partial class SketchUploaderForm1 : Form
    {
        private uploaderClass _uploader= new uploaderClass();
        private ComPort comport;
        
        public SketchUploaderForm1()
        {
            InitializeComponent();
            Init();
        }
        
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        public void Init()
        {
            /*try
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
            }*/

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
                _uploader.uploadSketch(textBox1.Text, model: _uploader.SetModel(),
                    comboBox2.Text, 9600);
                MessageBox.Show("Sketch download proccess is successful");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _uploader.uploadCheckSketch(comboBox2.Text);
                MessageBox.Show("Sketch download proccess is successful");
                comport = new ComPort(comboBox2.Text, 9600);
                comport.ConnectToArduino();
                comport.InBuffClear();
                comport.OutBuffClear();
                System.Threading.Thread.Sleep(1000);
                if (comport.getData()[0].ToString() == "/")
                {
                    button3.ForeColor = Color.Chartreuse;
                }
                comport.DisconnectFromArduino();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SketchUploaderForm1_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        
    }
}