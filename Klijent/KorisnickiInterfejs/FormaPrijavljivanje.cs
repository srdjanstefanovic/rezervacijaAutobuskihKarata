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
    public partial class FormaPrijavljivanje : Form
    {
        Timer timer;

       
        private void ProveriKonekcijuSaServerom(object sender, EventArgs e)
        {
            if (Komunikacija.krajK)
            {
                timer.Stop();
                MessageBox.Show("Server je zaustavljen");
                Application.Exit();
            }
        }


        public FormaPrijavljivanje()
        {
            InitializeComponent();
        }

        private void FormaPrijavljivanje_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.PoveziSeNaServer())
            {

                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += ProveriKonekcijuSaServerom;
                timer.Start();

                try
                {
                    if (KontrolerKI.PronadjiZaposlenog(txtKorisnickoIme, txtLozinka))
                    {
                        this.Hide();
                        new FormaPocetna().ShowDialog();
                        this.Show();
                    }

                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Neuspesno povezivanje na server!");
            }
        }

        
    }
}
