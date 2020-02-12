using Domen;
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
    public partial class FormaUnosRezervacije : Form
    {
        public FormaUnosRezervacije()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KreirajRezervaciju(txtSifraRezervacije, gbRezervacija, gbStavkeRezervacije, btnKreiraj, cmbLinija,cmbPutnik,dgvStavkeRezervacije,txtDatumRezervacije);
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajStavkuRezervacije(cmbLinija, txtCenaStavke, txtUkupnaCena, lblTrajanjePuta);
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiStavkuRezervacije(dgvStavkeRezervacije, txtUkupnaCena);
        }

        private void cmbLinija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnZapamtiRezervaciju_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiRezervaciju(txtDatumRezervacije,cmbPutnik,cmbValuta))
            {
                this.Close();
            }
        }

        private void FormaUnosRezervacije_Load(object sender, EventArgs e)
        {
            cmbValuta.DataSource = Enum.GetValues(typeof(Valuta));
        }
    }
}
