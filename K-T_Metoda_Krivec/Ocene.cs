using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_T_Metoda_Krivec
{
    public partial class Ocene : Form
    {
        public List<string> Alternative2 = new List<string>();
        public List<string> Parametri2 = new List<string>();


        public Ocene(List<string> Alternative, List<string> Parametri)
        {
            this.Alternative2 = Alternative;
            this.Parametri2= Parametri;

            InitializeComponent();


            foreach (string columnHeader in Alternative2)
            {
                Podatki.Columns.Add(columnHeader, columnHeader);
            }

            foreach (string rowHeader in Parametri2)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = rowHeader;
                Podatki.Rows.Add(row);
            }

            Podatki.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

        }

        private void Izracunaj_Click(object sender, EventArgs e)
        {
          /*  List<int[]> data = new List<int[]>();
            foreach (DataGridViewRow row in Podatki.Rows)
            {
                    // Get the cell values for the current row
                    int[] rowData = new int[row.Cells.Count];
                    for (int col = 0; col < row.Cells.Count; col++)
                    {
                        // Check if the cell value is not null
                        if (row.Cells[col].Value != null)
                        {
                            int cellValue = 0;
                            int.TryParse(row.Cells[col].Value.ToString(), out cellValue);
                            rowData[col] = cellValue;
                        }
                        else
                        {
                            // Assign a default value of 0 if the cell value is null
                            rowData[col] = 0;
                        }
                    }
                    data.Add(rowData);
            }*/

            List<int> UteziParametrov = new List<int>();

            for (int i = 0; i < Podatki.Rows.Count; i++)
            {
                string headerText = Podatki.Rows[i].HeaderCell.Value?.ToString();
                int intValue = 0;

                if (!string.IsNullOrEmpty(headerText))
                {
                    int openParenIndex = headerText.IndexOf("(");
                    int closeParenIndex = headerText.IndexOf(")");

                    if (openParenIndex >= 0 && closeParenIndex > openParenIndex)
                    {
                        string numberText = headerText.Substring(openParenIndex + 1, closeParenIndex - openParenIndex - 1);
                        int.TryParse(numberText, out intValue);
                    }

                    UteziParametrov.Add(intValue);
                }
            }

            
            List<int> rezultati = new List<int>();
            List<List<int>> data = new List<List<int>>();

            for (int j = 0; j < Podatki.Columns.Count; j++) // start at index 1 to skip the header column
            {
                List<int> values = new List<int>();
                for (int i = 0; i < Podatki.Rows.Count; i++) // start at index 1 to skip the header row
                {
                    if (int.TryParse(Podatki.Rows[i].Cells[j].Value?.ToString(), out int value))
                    {
                        values.Add(value);
                    }
                }
                data.Add(values);
                List<int> multipliedValues = new List<int>();
                for (int i = 0; i < values.Count; i++)
                {
                    multipliedValues.Add(values[i] * UteziParametrov[i]);
                }

                int result = multipliedValues.Sum();
                rezultati.Add(result);
            }
            // Iterate over the columns in the DataGridView

            foreach (int sum in rezultati)
            {
                listView1.Items.Add(sum.ToString());
            }

            Rezultati REZULTATI = new Rezultati(rezultati, Alternative2, Parametri2, UteziParametrov,data );

            REZULTATI.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Podatki_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          /*  if (e.RowIndex >= Podatki.ColumnCount) // check if the row being edited has no header
            {
                e.Cancel = true; // cancel the edit operation
            }*/
        }
    }
}
