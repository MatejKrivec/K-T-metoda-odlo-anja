namespace K_T_Metoda_Krivec
{
    partial class Ocene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Podatki = new System.Windows.Forms.DataGridView();
            this.Izracunaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Podatki)).BeginInit();
            this.SuspendLayout();
            // 
            // Podatki
            // 
            this.Podatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Podatki.Location = new System.Drawing.Point(44, 25);
            this.Podatki.Name = "Podatki";
            this.Podatki.RowTemplate.Height = 28;
            this.Podatki.Size = new System.Drawing.Size(535, 309);
            this.Podatki.TabIndex = 0;
            this.Podatki.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Podatki_CellBeginEdit);
            this.Podatki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Izracunaj
            // 
            this.Izracunaj.Location = new System.Drawing.Point(622, 406);
            this.Izracunaj.Name = "Izracunaj";
            this.Izracunaj.Size = new System.Drawing.Size(114, 32);
            this.Izracunaj.TabIndex = 1;
            this.Izracunaj.Text = "Izračunaj";
            this.Izracunaj.UseVisualStyleBackColor = true;
            this.Izracunaj.Click += new System.EventHandler(this.Izracunaj_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(622, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 309);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Ocene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Izracunaj);
            this.Controls.Add(this.Podatki);
            this.Name = "Ocene";
            this.Text = "Ocene";
            ((System.ComponentModel.ISupportInitialize)(this.Podatki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Podatki;
        private System.Windows.Forms.Button Izracunaj;
        private System.Windows.Forms.ListView listView1;
    }
}