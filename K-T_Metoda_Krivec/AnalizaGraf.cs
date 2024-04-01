using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace K_T_Metoda_Krivec
{
    public partial class AnalizaGraf : Form
    {
        public List<string> ImenaAlternativ = new List<string>();

        public List<List<int>> TockeAlternativ = new List<List<int>>();

        public AnalizaGraf(List<List<int>> TockeAlternativ2, List<string> ImenaAlternativ2)
        {
            InitializeComponent();

            this.TockeAlternativ = TockeAlternativ2;
            this.ImenaAlternativ = ImenaAlternativ2;

            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Loop through the list of line names in ImenaAlternativ
            for (int i = 0; i < ImenaAlternativ.Count; i++)
            {
                // Create a new series for the line chart and set its name
                Series lineData = new Series(ImenaAlternativ[i]);

                // Add the points from the inner list to the series
                for (int j = 0; j < TockeAlternativ[i].Count; j++)
                {
                    lineData.Points.AddXY(j, TockeAlternativ[i][j]);
                }

                // Set the chart type to "Line"
                chart1.Series.Add(lineData);
                chart1.Series[ImenaAlternativ[i]].ChartType = SeriesChartType.Line;
            }


        }
    }
}
