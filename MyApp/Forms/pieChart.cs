using System;
using System.Windows.Forms;
using DatabaseDLL;
using LiveCharts.Wpf;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace MyApp.Forms
{
    public partial class pieChart : Form
    {
        private DbClass dbClass = new DbClass();
        
        public pieChart()
        {
            InitializeComponent();
            dbClass.Connect("valentin", "1234", "mydatabase");
            string[][] x = dbClass.Select("new2");
            string[] seriesArray = {"Температура", "Влажность", "ДБ", "Яркость"};
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
            
            chart1.Titles.Add("Pie Chart");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            for (int i = 0; i < a.Length; i++)
            {
                //Series series = this.chart1.Series.Add(seriesArray[i]);
                chart1.Series["s1"].Points.AddXY(seriesArray[i], a[i]);
                //series.Points.AddXY(i, a[i]);

            }
            
        }

        
    }
}