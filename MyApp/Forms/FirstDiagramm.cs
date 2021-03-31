using System;
using System.Globalization;
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
            _dbClass.Connect("admin", "1234", "mydatabase");
            string[][] x = _dbClass.Select("new2");
            string[] seriesArray = {"Температура", "Влажность", "ДБ", "Яркость"};
            int[] pointsArray = {1, 2, 3, 4};

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Среднее");

            
            
            int rows = x[0].Length;
            int cols = x.Length;
            int[] a = new int[4];
            float[] b = new float[4];
            int z = 0;
            for (int i = 0; i < rows - 1; i++)//->
            {
                a[i] = 0;
                for (int j = 0; j < cols - 1; j++)
                {
                    z = Int32.Parse(x[i][j])/2;
                    a[i] = +z;
                }
                a[i] = a[i] / cols - 1;
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