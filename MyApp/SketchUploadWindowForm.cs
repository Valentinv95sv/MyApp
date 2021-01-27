using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUIHandlerDLL
{
    public partial class myForm : Form
    {
        private GuiHandler _handler = new GuiHandler();

        public myForm()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            try
            {
                foreach (var i in _handler.getModelList())
                {
                    comboBox1.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                foreach (var i in _handler.getPorts())
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
            textBox1.Text = _handler.openfile();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _handler.Init(textBox1.Text.ToString(), model: _handler.SetModel(comboBox1.SelectedItem.ToString()),
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