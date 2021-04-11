using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DatabaseDLL;

namespace MyApp.Forms
{
    public partial class FirstDiagramm : Form
    {
        private DbClass _dbClass = new DbClass();

        public FirstDiagramm()
        {
            InitializeComponent();
        }


        private void FirstDiagramm_Load(object sender, EventArgs e)
        {
            _dbClass.Connect("valentin", "12345678", "mydatabase");
            string[][] x = _dbClass.Select("new2");
            string[] seriesArray = {"Температура", "Влажность", "ДБ", "Яркость"};

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Среднее");
            
            int rows = x[0].Length;
            int cols = x.Length;
            int[] a = new int[4];
            int z = 0;
            for (int i = 0; i < cols; i++)//->
            {
                a[i] = 0;
                for (int j = 0; j < rows - 1; j++)
                {
                    a[i] = a[i] + Convert.ToInt32(x[i][j]);
                }
                a[i] = a[i] / rows;
            }
            
            // Add series.
            for (int i = 0; i < a.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(a[i]);

            }
        }
    }
}