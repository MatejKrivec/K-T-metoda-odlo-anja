using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace K_T_Metoda_Krivec
{
    public partial class Rezultati : Form
    {

        public List<int> VrednostiRezultatov = new List<int>();
        public List<string> Alternative = new List<string>();

        public List<int> utezi2 = new List<int>();
        public List<string> Parametri2 = new List<string>();
       // public List<int[]> data = new List<int[]>();

        public List<List<int>> data = new List<List<int>>();

        public Rezultati(List<int> Rezultati, List<string> ImenaAlternativ, List<string> Parametri, List<int> Utezi, List<List<int>> data2)
        {

            this.VrednostiRezultatov = Rezultati;
            this.Alternative = ImenaAlternativ;

            this.Parametri2 = Parametri;
            this.utezi2 = Utezi;

            this.data = data2;

            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int maxVal = VrednostiRezultatov.Max();
            int maxIndex = VrednostiRezultatov.IndexOf(maxVal);

            string ime = Alternative.ElementAt(maxIndex);

            label1.Text = "Najboljša alternativa je: " + ime + " z " + maxVal + " tockami";

            if (chart1.Series.IndexOf("Series1") != -1)
            {
                // Remove the existing series
                chart1.Series.Remove(chart1.Series["Series1"]);
            }

            this.Controls.Add(chart1);
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;

            for (int i = 0; i < VrednostiRezultatov.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(Alternative[i], VrednostiRezultatov[i]);
            }

            if (chart2.Series.IndexOf("Series2") != -1)
            {
                // Remove the existing series
                chart2.Series.Remove(chart1.Series["Series2"]);
            }

            // this.Controls.Add(chart1);
            chart2.Series.Add("Series2");
            chart2.Series["Series2"].ChartType = SeriesChartType.Pie;

            chart2.Series["Series2"].Points.DataBindXY(Parametri2, utezi2);

            // Check if the legend already exists
            if (chart2.Legends.IndexOf("Legend2") == -1)
            {
                // Add a new legend only if it doesn't already exist
                chart2.Legends.Add("Legend2");
            }

            // Customize the appearance of the chart
            chart2.Legends["Legend2"].Enabled = true;
            chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart2.Series["Series2"].Label = "#VALX (#PERCENT{P0})";
            chart2.Series["Series2"].LegendText = "#VALX";

            foreach (string item in Parametri2)
            {
                comboBox1.Items.Add(item);
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            int index = Parametri2.FindIndex(x => x == selectedValue); //Nastavitev za katero utez se bo izvedla analiza

            List<List<int>> list_tock = new List<List<int>>();

            foreach (List<int> list in data)
            {
                List<int> tocke = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    utezi2[index] = i + 1;

                    List<int> result = new List<int>();

                    for (int x = 0; x < utezi2.Count; x++)
                    {
                        result.Add(utezi2[x] * list[x]);        //Racunanje vrednosti utezi
                    }

                    int sum = 0;
                    foreach (int value in result)       //Racunanje tock
                    {
                        sum += value;
                    }

                    tocke.Add(sum);  //dodajanje tock v list


                }
                list_tock.Add(tocke); //tocke za eno alternativo
            }
            AnalizaGraf analizagraf = new AnalizaGraf(list_tock,Alternative);

            analizagraf.Show();
        }

        
    }
}
