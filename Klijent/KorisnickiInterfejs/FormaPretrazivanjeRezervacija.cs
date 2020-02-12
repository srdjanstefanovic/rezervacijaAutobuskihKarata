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
    public partial class FormaPretrazivanjeRezervacija : Form
    {
        public FormaPretrazivanjeRezervacija()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormaPretrazivanjeRezervacija_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniCmbPutnik(cmbPutnik);
        }

        private void cmbPutnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretrazivanjeRezervacija(cmbPutnik, dgvRezervacije);
        }

        private void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.UcitajRezervaciju(dgvRezervacije))
            {
                this.Hide();
                new FormaDetaljiRezervacije().ShowDialog();
                this.Show();

                //osvezavanje grida
                KontrolerKI.PretrazivanjeRezervacija(cmbPutnik, dgvRezervacije);
            }
        }
    }
}
