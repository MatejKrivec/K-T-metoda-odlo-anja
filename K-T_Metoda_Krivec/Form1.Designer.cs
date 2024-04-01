namespace K_T_Metoda_Krivec
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DodajAlternativo = new System.Windows.Forms.Button();
            this.DodajParameter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.IzbrisiAlternativo_button = new System.Windows.Forms.Button();
            this.izbrisiParameter_Button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Utez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(612, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 26);
            this.textBox2.TabIndex = 1;
            // 
            // DodajAlternativo
            // 
            this.DodajAlternativo.Location = new System.Drawing.Point(227, 76);
            this.DodajAlternativo.Name = "DodajAlternativo";
            this.DodajAlternativo.Size = new System.Drawing.Size(75, 33);
            this.DodajAlternativo.TabIndex = 2;
            this.DodajAlternativo.Text = "+";
            this.DodajAlternativo.UseVisualStyleBackColor = true;
            this.DodajAlternativo.Click += new System.EventHandler(this.Dodaj_Alternativo);
            // 
            // DodajParameter
            // 
            this.DodajParameter.Location = new System.Drawing.Point(769, 79);
            this.DodajParameter.Name = "DodajParameter";
            this.DodajParameter.Size = new System.Drawing.Size(75, 31);
            this.DodajParameter.TabIndex = 3;
            this.DodajParameter.Text = "+";
            this.DodajParameter.UseVisualStyleBackColor = true;
            this.DodajParameter.Click += new System.EventHandler(this.Dodaj_Parameter);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(82, 227);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 180);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(612, 227);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(276, 180);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Naprej na ocene";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NaprejNaOcene);
            // 
            // IzbrisiAlternativo_button
            // 
            this.IzbrisiAlternativo_button.Location = new System.Drawing.Point(82, 429);
            this.IzbrisiAlternativo_button.Name = "IzbrisiAlternativo_button";
            this.IzbrisiAlternativo_button.Size = new System.Drawing.Size(149, 33);
            this.IzbrisiAlternativo_button.TabIndex = 7;
            this.IzbrisiAlternativo_button.Text = "Izbriši alternativo";
            this.IzbrisiAlternativo_button.UseVisualStyleBackColor = true;
            this.IzbrisiAlternativo_button.Click += new System.EventHandler(this.IzbrisiAlternativo);
            // 
            // izbrisiParameter_Button
            // 
            this.izbrisiParameter_Button.Location = new System.Drawing.Point(612, 431);
            this.izbrisiParameter_Button.Name = "izbrisiParameter_Button";
            this.izbrisiParameter_Button.Size = new System.Drawing.Size(143, 31);
            this.izbrisiParameter_Button.TabIndex = 8;
            this.izbrisiParameter_Button.Text = "Izbriši parameter";
            this.izbrisiParameter_Button.UseVisualStyleBackColor = true;
            this.izbrisiParameter_Button.Click += new System.EventHandler(this.IzbrisiParameter);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(702, 151);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(164, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Utez
            // 
            this.Utez.Location = new System.Drawing.Point(640, 151);
            this.Utez.Name = "Utez";
            this.Utez.Size = new System.Drawing.Size(32, 26);
            this.Utez.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ustvari alternative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ustvari parametre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Utez);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.izbrisiParameter_Button);
            this.Controls.Add(this.IzbrisiAlternativo_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DodajParameter);
            this.Controls.Add(this.DodajAlternativo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DodajAlternativo;
        private System.Windows.Forms.Button DodajParameter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button IzbrisiAlternativo_button;
        private System.Windows.Forms.Button izbrisiParameter_Button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox Utez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

