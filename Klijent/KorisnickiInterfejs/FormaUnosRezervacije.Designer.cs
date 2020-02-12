namespace Klijent.KorisnickiInterfejs
{
    partial class FormaUnosRezervacije
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRezervacija = new System.Windows.Forms.GroupBox();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnZapamtiRezervaciju = new System.Windows.Forms.Button();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbStavkeRezervacije = new System.Windows.Forms.GroupBox();
            this.lblTrajanjePuta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvStavkeRezervacije = new System.Windows.Forms.DataGridView();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.cmbLinija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPutnik = new System.Windows.Forms.ComboBox();
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtSifraRezervacije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbRezervacija.SuspendLayout();
            this.gbStavkeRezervacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbRezervacija);
            this.panel1.Controls.Add(this.btnKreiraj);
            this.panel1.Controls.Add(this.txtSifraRezervacije);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 439);
            this.panel1.TabIndex = 0;
            // 
            // gbRezervacija
            // 
            this.gbRezervacija.Controls.Add(this.cmbValuta);
            this.gbRezervacija.Controls.Add(this.label8);
            this.gbRezervacija.Controls.Add(this.btnZapamtiRezervaciju);
            this.gbRezervacija.Controls.Add(this.txtUkupnaCena);
            this.gbRezervacija.Controls.Add(this.label6);
            this.gbRezervacija.Controls.Add(this.gbStavkeRezervacije);
            this.gbRezervacija.Controls.Add(this.cmbPutnik);
            this.gbRezervacija.Controls.Add(this.txtDatumRezervacije);
            this.gbRezervacija.Controls.Add(this.label4);
            this.gbRezervacija.Controls.Add(this.label2);
            this.gbRezervacija.Enabled = false;
            this.gbRezervacija.Location = new System.Drawing.Point(22, 61);
            this.gbRezervacija.Name = "gbRezervacija";
            this.gbRezervacija.Size = new System.Drawing.Size(713, 364);
            this.gbRezervacija.TabIndex = 6;
            this.gbRezervacija.TabStop = false;
            this.gbRezervacija.Text = "Unos rezervacije";
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(520, 56);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(87, 21);
            this.cmbValuta.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valuta:";
            // 
            // btnZapamtiRezervaciju
            // 
            this.btnZapamtiRezervaciju.Location = new System.Drawing.Point(30, 323);
            this.btnZapamtiRezervaciju.Name = "btnZapamtiRezervaciju";
            this.btnZapamtiRezervaciju.Size = new System.Drawing.Size(655, 35);
            this.btnZapamtiRezervaciju.TabIndex = 14;
            this.btnZapamtiRezervaciju.Text = "Zapamti rezervaciju";
            this.btnZapamtiRezervaciju.UseVisualStyleBackColor = true;
            this.btnZapamtiRezervaciju.Click += new System.EventHandler(this.btnZapamtiRezervaciju_Click);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUkupnaCena.Location = new System.Drawing.Point(635, 56);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(72, 20);
            this.txtUkupnaCena.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ukupna cena:";
            // 
            // gbStavkeRezervacije
            // 
            this.gbStavkeRezervacije.Controls.Add(this.lblTrajanjePuta);
            this.gbStavkeRezervacije.Controls.Add(this.label7);
            this.gbStavkeRezervacije.Controls.Add(this.btnObrisiStavku);
            this.gbStavkeRezervacije.Controls.Add(this.btnDodajStavku);
            this.gbStavkeRezervacije.Controls.Add(this.dgvStavkeRezervacije);
            this.gbStavkeRezervacije.Controls.Add(this.txtCenaStavke);
            this.gbStavkeRezervacije.Controls.Add(this.cmbLinija);
            this.gbStavkeRezervacije.Controls.Add(this.label5);
            this.gbStavkeRezervacije.Controls.Add(this.label3);
            this.gbStavkeRezervacije.Enabled = false;
            this.gbStavkeRezervacije.Location = new System.Drawing.Point(30, 89);
            this.gbStavkeRezervacije.Name = "gbStavkeRezervacije";
            this.gbStavkeRezervacije.Size = new System.Drawing.Size(677, 227);
            this.gbStavkeRezervacije.TabIndex = 11;
            this.gbStavkeRezervacije.TabStop = false;
            this.gbStavkeRezervacije.Text = "Unos stavki rezervacije";
            // 
            // lblTrajanjePuta
            // 
            this.lblTrajanjePuta.AutoSize = true;
            this.lblTrajanjePuta.Location = new System.Drawing.Point(284, 91);
            this.lblTrajanjePuta.Name = "lblTrajanjePuta";
            this.lblTrajanjePuta.Size = new System.Drawing.Size(10, 13);
            this.lblTrajanjePuta.TabIndex = 15;
            this.lblTrajanjePuta.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trajanje putovanja na liniji koju ste poslednju izabrali:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(510, 60);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(138, 23);
            this.btnObrisiStavku.TabIndex = 13;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(510, 23);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(138, 23);
            this.btnDodajStavku.TabIndex = 5;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // dgvStavkeRezervacije
            // 
            this.dgvStavkeRezervacije.AllowUserToAddRows = false;
            this.dgvStavkeRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRezervacije.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStavkeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRezervacije.Location = new System.Drawing.Point(25, 118);
            this.dgvStavkeRezervacije.Name = "dgvStavkeRezervacije";
            this.dgvStavkeRezervacije.Size = new System.Drawing.Size(630, 103);
            this.dgvStavkeRezervacije.TabIndex = 4;
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Location = new System.Drawing.Point(78, 62);
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(386, 20);
            this.txtCenaStavke.TabIndex = 3;
            // 
            // cmbLinija
            // 
            this.cmbLinija.FormattingEnabled = true;
            this.cmbLinija.Location = new System.Drawing.Point(78, 25);
            this.cmbLinija.Name = "cmbLinija";
            this.cmbLinija.Size = new System.Drawing.Size(386, 21);
            this.cmbLinija.TabIndex = 2;
            this.cmbLinija.SelectedIndexChanged += new System.EventHandler(this.cmbLinija_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Linija:";
            // 
            // cmbPutnik
            // 
            this.cmbPutnik.FormattingEnabled = true;
            this.cmbPutnik.Location = new System.Drawing.Point(117, 59);
            this.cmbPutnik.Name = "cmbPutnik";
            this.cmbPutnik.Size = new System.Drawing.Size(377, 21);
            this.cmbPutnik.TabIndex = 10;
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDatumRezervacije.Location = new System.Drawing.Point(117, 20);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.ReadOnly = true;
            this.txtDatumRezervacije.Size = new System.Drawing.Size(377, 20);
            this.txtDatumRezervacije.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Putnik: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(320, 19);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(409, 23);
            this.btnKreiraj.TabIndex = 5;
            this.btnKreiraj.Text = "Kreiraj rezervaciju";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtSifraRezervacije
            // 
            this.txtSifraRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSifraRezervacije.Location = new System.Drawing.Point(150, 19);
            this.txtSifraRezervacije.Name = "txtSifraRezervacije";
            this.txtSifraRezervacije.ReadOnly = true;
            this.txtSifraRezervacije.Size = new System.Drawing.Size(127, 20);
            this.txtSifraRezervacije.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Šifra rezervacije:";
            // 
            // FormaUnosRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormaUnosRezervacije";
            this.Text = "Unos rezervacije";
            this.Load += new System.EventHandler(this.FormaUnosRezervacije_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbRezervacija.ResumeLayout(false);
            this.gbRezervacija.PerformLayout();
            this.gbStavkeRezervacije.ResumeLayout(false);
            this.gbStavkeRezervacije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbRezervacija;
        private System.Windows.Forms.Button btnZapamtiRezervaciju;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbStavkeRezervacije;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvStavkeRezervacije;
        private System.Windows.Forms.TextBox txtCenaStavke;
        private System.Windows.Forms.ComboBox cmbLinija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPutnik;
        private System.Windows.Forms.TextBox txtDatumRezervacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtSifraRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrajanjePuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.Label label8;
    }
}