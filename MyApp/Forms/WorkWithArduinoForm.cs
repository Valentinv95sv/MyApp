using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using ComPortParserDLL;
using DatabaseDLL;
using SketchUploaderDLL;

namespace MyApp
{
    public partial class WorkWithArduinoForm : Form
    {
        private DbClass _dbClass;
        private ComPort _comPort;
        private uploaderClass _uploader= new uploaderClass();
        private string[][] x;
        
        public WorkWithArduinoForm()
        {
            InitializeComponent();
            Init();
            _dbClass = new DbClass();
            _comPort = new ComPort(comboBox1.Text , 9600);
            _comPort.timer_inint(timer1_Elapsed);

        }
        
        private void LoadTheme()
        {
            foreach (Control btns in this.panel1.Controls)
                
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
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns.Add("1", "Температура");
            dataGridView1.Columns.Add("2", "Влажность");
            dataGridView1.Columns.Add("3", "ДБ");
            dataGridView1.Columns.Add("4", "Яркость");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dbClass.Connect("valentin", "1234", "mydatabase");
            x = _dbClass.Select("new2");
            
        }
        
        private void getdata()
        {
            int rows = x[0].Length;
            int cols = x.Length;
            string[] a = new string[cols];
            for (int i = 0; i < rows; i++)//->
            {
                for (int j = 0; j < cols; j++)
                {
                    a[j] = x[j][i];
                }
                dataGridView1.Rows.Add(a);
            }
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] a = _comPort.Split(_comPort.getData());
            string[] c = {"C1", "C2", "C3", "C4"};
            string b = null;
            _dbClass.Insert("new2", a, c);
            foreach (var i in a)
            {
                b += i + " | ";
            }
            //textBox4.AppendText(b);
            b = null;
            //textBox4.AppendText(Environment.NewLine);
            x = _dbClass.Select("new2");
            dataGridView1.Rows.Add(a);
            dataGridView1.Refresh();
        }
        
        private void OpenPort_Click(object sender, EventArgs e)
        {
            _comPort.ConnectToArduino();
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            _comPort.DisconnectFromArduino();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            dataGridView1.Columns.Add("1", "Температура");
            dataGridView1.Columns.Add("2", "Влажность");
            dataGridView1.Columns.Add("3", "ДБ");
            dataGridView1.Columns.Add("4", "Яркость");
            dataGridView1.Refresh();
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            string[] a = {"C1:varchar(100)", "C2:varchar(100)", "C3:varchar(100)", "C4:varchar(100)" };
            if (_dbClass.CreateTable("new2", a))
            {
                CreateTable.BackColor = Color.Chartreuse;
            }
        }

        private void TruncateTable_Click(object sender, EventArgs e)
        {
            _dbClass.deleteAll("new2");
        }

        private void PortWrite_Click(object sender, EventArgs e)
        {
            _comPort.Write(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _dbClass.DeleteTable("new2");
            CreateTable.BackColor = Color.LightGray;
        }

        private void AllDataFromDB_Click(object sender, EventArgs e)
        {
            //string[][] x = _dbClass.Select("new2");
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.Columns.Add("1", "Температура");
            dataGridView1.Columns.Add("2", "Влажность");
            dataGridView1.Columns.Add("3", "ДБ");
            dataGridView1.Columns.Add("4", "Яркость");

            if (x[0].Length == 0)
            {
                int[] y = new[] {0,0,0,0};
                dataGridView1.Rows.Add(y);
            }
            else
            {
                int rows = x[0].Length;
                int cols = x.Length;
                string[] a = new string[cols];
                for (int i = 0; i < rows; i++)//->
                {
                    for (int j = 0; j < cols; j++)
                    {
                        a[j] = x[j][i];
                    }
                    dataGridView1.Rows.Add(a);
                } 
            }
            
            
        }

        private void WorkWithArduinoForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _dbClass.CreateDB("myDB");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _dbClass.DeleteDB("myDB");
        }
    }
}