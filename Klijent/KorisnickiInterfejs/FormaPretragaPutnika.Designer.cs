namespace Klijent.KorisnickiInterfejs
{
    partial class FormaPretragaPutnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPutnici = new System.Windows.Forms.DataGridView();
            this.txtKriterijumPretrage = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriterijum pretrage:";
            // 
            // dgvPutnici
            // 
            this.dgvPutnici.AllowUserToAddRows = false;
            this.dgvPutnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPutnici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPutnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutnici.Location = new System.Drawing.Point(27, 84);
            this.dgvPutnici.Name = "dgvPutnici";
            this.dgvPutnici.Size = new System.Drawing.Size(746, 218);
            this.dgvPutnici.TabIndex = 1;
            this.dgvPutnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPutnici_CellDoubleClick);
            // 
            // txtKriterijumPretrage
            // 
            this.txtKriterijumPretrage.Location = new System.Drawing.Point(134, 22);
            this.txtKriterijumPretrage.Name = "txtKriterijumPretrage";
            this.txtKriterijumPretrage.Size = new System.Drawing.Size(374, 20);
            this.txtKriterijumPretrage.TabIndex = 2;
            this.txtKriterijumPretrage.TextChanged += new System.EventHandler(this.txtKriterijumPretrage_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(550, 22);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(223, 47);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(pretraga će biti izvršena nad sledećim atributima putnika: Šifra, Ime, Prezime, " +
    "JMBG)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormaPretragaPutnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtKriterijumPretrage);
            this.Controls.Add(this.dgvPutnici);
            this.Controls.Add(this.label1);
            this.Name = "FormaPretragaPutnika";
            this.Text = "Pretraga putnika";
            this.Load += new System.EventHandler(this.FormaPretragaPutnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPutnici;
        private System.Windows.Forms.TextBox txtKriterijumPretrage;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label2;
    }
}