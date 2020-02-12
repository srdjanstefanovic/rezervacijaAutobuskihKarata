using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.PokreniServer())
            {
                lblStatus.Text = "Server je pokrenut!";
                btnPokreniServer.Enabled = false;
                btnZaustaviServer.Enabled = true;
            }
        }

        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            /*if (Server.listaTokova.Count>0)
            {
                MessageBox.Show("Server ne moze biti ugasen.\nPostoje klijenti na sistemu!");
            }*/

            if (s.ZaustaviServer())
            {
                lblStatus.Text = "Server je zaustavljen!";
                btnPokreniServer.Enabled = true;
                btnZaustaviServer.Enabled = false;
            }
        }
    }
}
