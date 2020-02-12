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
    public partial class FormaDetaljiPutnika : Form
    {
        public FormaDetaljiPutnika()
        {
            InitializeComponent();
        }

        private void FormaDetaljiPutnika_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaPutnika(txtSifraPutnika, txtImePutnika, txtPrezimePutnika, cmbPol, txtJmbg, txtDatumRodjenja, txtKontaktTelefon);
        }

        private void btnZapamtiPutnika_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiPutnika(txtImePutnika, txtPrezimePutnika,
                cmbPol, txtJmbg, txtDatumRodjenja, txtKontaktTelefon))
            {
                // ako je uspesno sacuvan, zatvori formu
                this.Close();
            }
        }

        private void btnObrisiPutnika_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiPutnika())
            {
                this.Close();
            }
        }
    }
}
