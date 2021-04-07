using System;
using System.Windows.Forms;
using DatabaseDLL;

namespace MyApp.Forms
{
    public partial class LinearChart : Form
    {
        private DbClass dbClass = new DbClass();
        public LinearChart()
        {
            InitializeComponent();
            string[] seriesArray = {"Температура", "Влажность", "ДБ", "Яркость"};
            dbClass.Connect("valentin", "1234", "mydatabase");
            string[][] x = dbClass.Select("new2");
            int rows = x[0].Length;
            int cols = x.Length;
            int[] a = new int[4];
            int z = 0;
            
            for (int i = 0; i < cols; i++)//->
            {
                chart1.Series[i.ToString()].IsValueShownAsLabel = true;
                for (int j = 0; j < rows; j++)
                {
                    chart1.Series[i.ToString()].Points.AddXY(j, Convert.ToInt32(x[i][j]));
                }
                
            }
            chart1.Titles.Add("Linear Chart");
        }
    }
}