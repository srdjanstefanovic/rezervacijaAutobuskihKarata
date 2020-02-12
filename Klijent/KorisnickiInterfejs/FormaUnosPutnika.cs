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
    public partial class FormaUnosPutnika : Form
    {
        public FormaUnosPutnika()
        {
            InitializeComponent();
        }

        private void FormaUnosPutnika_Load(object sender, EventArgs e)
        {
            cmbPol.DataSource = Enum.GetValues(typeof(Pol));
        }

        private void btnKreirajPutnika_Click(object sender, EventArgs e)
        {
            KontrolerKI.KreirajPutnika(txtSifraPutnika, gbPutnik, btnKreirajPutnika);
        }

        private void btnZapamtiPutnika_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiPutnika(txtImePutnika,txtPrezimePutnika,
                cmbPol,txtJmbg,txtDatumRodjenja,txtKontaktTelefon))
            {
                // ako je uspesno sacuvan, zatvori formu
                this.Close();
            }

        }
    }
}
