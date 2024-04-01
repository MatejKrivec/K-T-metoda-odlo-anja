using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace K_T_Metoda_Krivec
{
    public partial class Form1 : Form
    {

        public List<string> Alternative = new List<string>();
        public List<string> Parametri = new List<string>();


        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Alternative", 175);

            listView2.View = View.Details;
            listView2.Columns.Add("Parametri", 175);

            Utez.Text = "1";
            Utez.ReadOnly = true;

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            trackBar1.Value = 1;
        }

        private void Dodaj_Alternativo(object sender, EventArgs e)
        {
            string itemText = textBox1.Text;
            ListViewItem newItem = new ListViewItem(itemText);
            listView1.Items.Add(newItem);
            textBox1.Text = "";
        }

        private void Dodaj_Parameter(object sender, EventArgs e)
        {
            string itemText = textBox2.Text;
            int trackBarValue = trackBar1.Value;
            string newItemText = $"{itemText}({trackBarValue})"; // string interpolation
            ListViewItem newItem = new ListViewItem(newItemText);
            listView2.Items.Add(newItem);
            textBox2.Text = "";
        }

        private void IzbrisiAlternativo(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(selectedItem);
            }
        }

        private void IzbrisiParameter(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView2.SelectedItems)
            {
                listView2.Items.Remove(selectedItem);
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Utez.Text = trackBar1.Value.ToString();
        }

        private void NaprejNaOcene(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                Alternative.Add(item.Text);
            }
            foreach (ListViewItem item in listView2.Items)
            {
                Parametri.Add(item.Text);
            }

            Ocene ocene= new Ocene(Alternative,Parametri);
            ocene.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
