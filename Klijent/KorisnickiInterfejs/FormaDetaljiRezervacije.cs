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
    public partial class FormaDetaljiRezervacije : Form
    {
        public FormaDetaljiRezervacije()
        {
            InitializeComponent();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajStavkuRezervacije(cmbLinija, txtCenaStavke, txtUkupnaCena, lblTrajanjePuta);
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiStavkuRezervacije(dgvStavkeRezervacije, txtUkupnaCena);
        }

        private void FormaDetaljiRezervacije_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaRezervacije(txtSifraRezervacije, txtDatumRezervacije, cmbPutnik, cmbValuta, txtUkupnaCena, cmbLinija, txtCenaStavke, dgvStavkeRezervacije);
        }

        private void btnZapamtiRezervaciju_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiRezervaciju(txtDatumRezervacije, cmbPutnik, cmbValuta))
            {
                this.Close();
            }
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiRezervaciju())
            {
                this.Close();
            }
        }
    }
}
