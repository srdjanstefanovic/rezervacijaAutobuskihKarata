namespace Klijent.KorisnickiInterfejs
{
    partial class FormaPretrazivanjeRezervacija
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
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPutnik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(26, 82);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(746, 218);
            this.dgvRezervacije.TabIndex = 3;
            this.dgvRezervacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite putnika:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPutnik
            // 
            this.cmbPutnik.FormattingEnabled = true;
            this.cmbPutnik.Location = new System.Drawing.Point(143, 20);
            this.cmbPutnik.Name = "cmbPutnik";
            this.cmbPutnik.Size = new System.Drawing.Size(302, 21);
            this.cmbPutnik.TabIndex = 9;
            this.cmbPutnik.SelectedIndexChanged += new System.EventHandler(this.cmbPutnik_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(duplim klikom na polje u tabeli prikazaće se podaci o toj rezervaciji)";
            // 
            // FormaPretrazivanjeRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPutnik);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "FormaPretrazivanjeRezervacija";
            this.Text = "Pretraživanje rezervacija";
            this.Load += new System.EventHandler(this.FormaPretrazivanjeRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPutnik;
        private System.Windows.Forms.Label label2;
    }
}