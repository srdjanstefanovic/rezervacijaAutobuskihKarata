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
    public partial class FormaPretragaPutnika : Form
    {
        public FormaPretragaPutnika()
        {
            InitializeComponent();
        }

        private void FormaPretragaPutnika_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretragaPutnika(txtKriterijumPretrage, dgvPutnici);
        }

        private void txtKriterijumPretrage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerKI.PretragaPutnika(txtKriterijumPretrage, dgvPutnici);
        }

        private void dgvPutnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.UcitajPutnika(dgvPutnici))
            {
                this.Hide();
                new FormaDetaljiPutnika().ShowDialog();
                this.Show();

                //osvezavanje podataka u gridu nakon izmene
                KontrolerKI.PretragaPutnika(txtKriterijumPretrage, dgvPutnici);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
