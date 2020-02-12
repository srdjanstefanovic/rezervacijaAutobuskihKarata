using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.KorisnickiInterfejs
{
    public partial class FormaPocetna : Form
    {
        public FormaPocetna()
        {
            InitializeComponent();
        }

        private void FormaPocetna_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.PrikaziPrijavljenogZaposlenog();
        }

        private void FormaPocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.Kraj();
        }

        private void unosPutnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new FormaUnosPutnika().ShowDialog();
            
        }

        private void pretragaPutnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaPretragaPutnika().ShowDialog();
            this.Show();
        }

        private void unosRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaUnosRezervacije().ShowDialog();
            this.Show();
        }

        private void pretragaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaPretrazivanjeRezervacija().ShowDialog();
            this.Show();
        }
    }
}
