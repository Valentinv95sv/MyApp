using System;
using System.Windows.Forms;
using DatabaseDLL;
using GUIHandlerDLL;

namespace MyApp
{
    public partial class DatabaseForm : Form
    {
        private GuiHandler _handler = new GuiHandler();
        public DatabaseForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
                _handler.DatabaseConnection(textBox2.Text.ToString(), textBox3.Text.ToString());
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var i in _handler.dbCount())
            {
                textBox1.AppendText(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _handler.insert();
        }
    }
}