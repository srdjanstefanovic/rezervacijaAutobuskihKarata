using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Zaposleni zaposleni;
        public static Putnik putnik;
        public static Rezervacija rezervacija;

        public static bool PoveziSeNaServer()
        {
            if (komunikacija==null)
            {
                komunikacija = new Komunikacija();
            }
            return komunikacija.PoveziSeNaServer();
        }

        public static void PopuniCmbPutnik(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (Putnik p in komunikacija.UcitajSvePutnike() as List<Putnik>)
            {
                cmb.Items.Add(p);
            }
            cmb.Text = "Izaberite putnika!";
        }

        internal static void PopuniPoljaRezervacije(TextBox txtSifraRezervacije, TextBox txtDatumRezervacije, ComboBox cmbPutnik, ComboBox cmbValuta, TextBox txtUkupnaCena, ComboBox cmbLinija, TextBox txtCenaStavke, DataGridView dgvStavkeRezervacije)
        {
            PopuniCmbPutnik(cmbPutnik);
            PopuniCmbLinija(cmbLinija);
            cmbValuta.DataSource = Enum.GetValues(typeof(Valuta));

            txtSifraRezervacije.Text = rezervacija.Id.ToString();
            txtDatumRezervacije.Text = rezervacija.DatumRezervacije.ToString("dd/MM/yyyy");
            cmbPutnik.Text = rezervacija.Putnik.ToString();
            txtUkupnaCena.Text = rezervacija.UkupanIznos.ToString();

            dgvStavkeRezervacije.DataSource = rezervacija.ListaStavki;

            
        }

        internal static bool ObrisiRezervaciju()
        {
            object o = komunikacija.ObrisiRezervaciju(rezervacija);

            if (o==null)
            {
                MessageBox.Show("Sistem ne može da obriše rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao rezervaciju!");
                return true;
            }

        }

        internal static void PretrazivanjeRezervacija(ComboBox cmbPutnik, DataGridView dgvRezervacije)
        {
            rezervacija = new Rezervacija();
            rezervacija.Putnik = cmbPutnik.SelectedItem as Putnik;
            if (rezervacija.Putnik == null)
            {
                MessageBox.Show("Niste odabrali putnika!");
                return;
            }

            

            rezervacija.Uslov = " PutnikID=" + rezervacija.Putnik.Id;
            dgvRezervacije.DataSource = komunikacija.PretrazivanjeRezervacija(rezervacija);

            List<Rezervacija> lista = komunikacija.PretrazivanjeRezervacija(rezervacija) as List<Rezervacija>;
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje rezervacije po zadatoj vrednosti!");
            }
            else
            {
                MessageBox.Show("Sistem je nasao rezervacije po zadatoj vrednosti!");
            }
        }

        internal static bool UcitajRezervaciju(DataGridView dgvRezervacije)
        {
            rezervacija = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;

            rezervacija = (Rezervacija) komunikacija.UcitajRezervaciju(rezervacija);

            if (rezervacija==null)
            {
                MessageBox.Show("Sistem ne moze da prikaže podatke o odabranoj rezervaciji!");
                return false;
            }
            else
            {
                MessageBox.Show("Prikazana je odabrana rezervacija!");
                return true;
            }
            
        }

        internal static void DodajStavkuRezervacije(ComboBox cmbLinija, TextBox txtCenaStavke, TextBox txtUkupnaCena, Label lblTrajanjePuta)
        {
            StavkaRezervacije sr = new StavkaRezervacije();
            sr.RezervacijaID = rezervacija.Id;
            sr.RedniBroj = rezervacija.ListaStavki.Count + 1;

            sr.Linija = cmbLinija.SelectedItem as Linija;
            if (sr.Linija == null)
            {
                MessageBox.Show("Izaberite liniju!");
                return;
            }
            if (sr.Linija.RaspoloziviBrojMesta < 1)
            {
                MessageBox.Show("Nema raspolozivih mesta za ovu liniju!");
                return;
            }

            try
            {
                sr.Cena = Convert.ToDouble(txtCenaStavke.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Cena nije ispravno uneta!");
                return;
            }

            if (sr.Cena < 0)
            {
                MessageBox.Show("Cena nije ispravno uneta!");
                return;
            }

            rezervacija.UkupanIznos += sr.Cena;
            txtUkupnaCena.Text = rezervacija.UkupanIznos.ToString();

            foreach (StavkaRezervacije stavka in rezervacija.ListaStavki)
            {
                if (stavka.Linija.Id == sr.Linija.Id)
                {
                    MessageBox.Show("Ta linija je vec izabrana!");
                    return;
                }
            }

            rezervacija.ListaStavki.Add(sr);

            lblTrajanjePuta.Text = sr.Linija.TrajanjePuta;

            PopuniCmbLinija(cmbLinija);
            txtCenaStavke.Clear();
        }

        internal static bool ZapamtiRezervaciju(TextBox txtDatumRezervacije, ComboBox cmbPutnik, ComboBox cmbValuta)
        {
            rezervacija.DatumRezervacije = DateTime.ParseExact(txtDatumRezervacije.Text, "dd/MM/yyyy", null);

            rezervacija.Putnik = cmbPutnik.SelectedItem as Putnik;
            if (rezervacija.Putnik == null)
            {
                MessageBox.Show("Niste odabrali putnika!");
                return false;
            }

            if (rezervacija.ListaStavki.Count < 1)
            {
                MessageBox.Show("Unesite barem jednu liniju!");
                return false;
            }

            try
            {
                rezervacija.Valuta = (Valuta)Enum.Parse(typeof(Valuta), cmbValuta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravan unos valute!");
                return false;
            }

            object rezultat = komunikacija.ZapamtiRezervaciju(rezervacija);

            if (rezultat == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti rezervaciju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio rezervaciju!");
                return true;
            }
        }

        internal static void ObrisiStavkuRezervacije(DataGridView dgvStavkeRezervacije, TextBox txtUkupnaCena)
        {
            try
            {
                StavkaRezervacije sr = dgvStavkeRezervacije.CurrentRow.DataBoundItem as StavkaRezervacije;
                rezervacija.ListaStavki.Remove(sr);

                //update rednih brojeva
                int i = 1;
                foreach (StavkaRezervacije stavka in rezervacija.ListaStavki)
                {
                    stavka.RedniBroj = i;
                    i++;
                }

                rezervacija.UkupanIznos -= sr.Cena;
                txtUkupnaCena.Text = rezervacija.UkupanIznos.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite stavku za brisanje!");
            }
        }

        public static void PopuniCmbLinija(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (Linija l in komunikacija.UcitajSveLinije() as List<Linija>)
            {
                cmb.Items.Add(l);
            }
            cmb.Text = "Izaberite liniju!";
        }

        internal static void KreirajRezervaciju(TextBox txtSifraRezervacije, GroupBox gbRezervacija, GroupBox gbStavkeRezervacije, Button btnKreiraj, ComboBox cmbLinija, ComboBox cmbPutnik, DataGridView dgvStavkeRezervacije, TextBox txtDatumRezervacije)
        {
            rezervacija = (Rezervacija)komunikacija.KreirajRezervaciju();

            if (rezervacija==null)
            {
                MessageBox.Show("Sistem ne može da kreira rezervaciju!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao rezervaciju");
                txtSifraRezervacije.Text = rezervacija.Id.ToString();
                btnKreiraj.Enabled = false;
                gbRezervacija.Enabled = true;
                gbStavkeRezervacije.Enabled = true;
                PopuniCmbLinija(cmbLinija);
                PopuniCmbPutnik(cmbPutnik);
                rezervacija.Zaposleni = zaposleni;
                dgvStavkeRezervacije.DataSource = rezervacija.ListaStavki;
                txtDatumRezervacije.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        internal static void PopuniPoljaPutnika(TextBox txtSifraPutnika, TextBox txtImePutnika, TextBox txtPrezimePutnika, ComboBox cmbPol, TextBox txtJmbg, TextBox txtDatumRodjenja, TextBox txtKontaktTelefon)
        {
            cmbPol.DataSource = Enum.GetValues(typeof(Pol));

            txtSifraPutnika.Text = putnik.Id.ToString();
            txtImePutnika.Text = putnik.Ime;
            txtPrezimePutnika.Text = putnik.Prezime;
            cmbPol.Text = putnik.Pol.ToString();
            txtJmbg.Text = putnik.Jmbg.ToString();
            txtDatumRodjenja.Text = putnik.DatumRodjenja.ToString("dd/MM/yyyy");
            txtKontaktTelefon.Text = putnik.KontaktTelefon;
        }

        internal static bool ObrisiPutnika()
        {
            object o = komunikacija.ObrisiPutnika(putnik);

            if (o==null)
            {
                MessageBox.Show("Sistem ne može da obriše putnika!");
                return false;
            } 
            else
            {
                MessageBox.Show("Sistem je obrisao putnika!");
                return true;
            }
        }

        internal static void PretragaPutnika(TextBox txtKriterijumPretrage, DataGridView dgvPutnici)
        {
            putnik = new Putnik();
            
            putnik.Uslov = " Ime like '" + txtKriterijumPretrage.Text + "%' or Prezime like '" + txtKriterijumPretrage.Text + "%' or JMBG like '" + txtKriterijumPretrage.Text+"' or PutnikID like '"+txtKriterijumPretrage.Text+"' ";

            List<Putnik> lista = (List<Putnik>)komunikacija.PretragaPutnika(putnik);

            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe putnike po zadatoj vrednosti!");
                return;
            }

            dgvPutnici.DataSource = lista;

            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe putnike po zadatoj vrednosti! [Ne postoje!]");
                return;
            }

            MessageBox.Show("Sistem je našao putnike po zadatoj vrednosti!");
        }

        internal static bool UcitajPutnika(DataGridView dgvPutnici)
        {
            try
            {
                putnik = dgvPutnici.CurrentRow.DataBoundItem as Putnik;

                putnik = (Putnik) komunikacija.UcitajPutnika(putnik);
                if (putnik == null)
                {
                    MessageBox.Show("Sistem ne može da prikaže putnika!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Prikazan je odabrani putnik!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali putnika");
                return false;
            }
        }

        internal static string PrikaziPrijavljenogZaposlenog()
        {
            return "Prijavljen je: "+zaposleni.ToString()+"  |  Vreme prijave: "+DateTime.Now.ToString("hh:mm");
        }

        internal static void KreirajPutnika(TextBox txtSifraPutnika, GroupBox gbPutnik, Button btnKreirajPutnika)
        {
            putnik = (Putnik) komunikacija.KreirajPutnika();

            if (putnik == null)
            {
                MessageBox.Show("Sistem ne može da kreira putnika!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao putnika!");
                txtSifraPutnika.Text = putnik.Id.ToString();
                btnKreirajPutnika.Enabled = false;
                gbPutnik.Enabled = true;
            }

        }

        internal static bool ZapamtiPutnika(TextBox txtImePutnika, TextBox txtPrezimePutnika, ComboBox cmbPol, TextBox txtJmbg, TextBox txtDatumRodjenja, TextBox txtKontaktTelefon)
        {
            putnik.Ime = txtImePutnika.Text;
            if (string.IsNullOrEmpty(putnik.Ime))
            {
                MessageBox.Show("Unesite ime putnika!");
                return false;
            }

            putnik.Prezime = txtPrezimePutnika.Text;
            if (string.IsNullOrEmpty(putnik.Prezime))
            {
                MessageBox.Show("Unesite prezime putnika!");
                return false;
            }

            try
            {
                putnik.Pol = (Pol)Enum.Parse(typeof(Pol), cmbPol.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravan unos pola!");
                return false;
            }

            putnik.Jmbg = txtJmbg.Text;
            if (putnik.Jmbg.Length != 13)
            {
                MessageBox.Show("JMBG nije ispravno unet!");
                return false;
            }
            try
            {
                long pomJMBG = Convert.ToInt64(putnik.Jmbg);
            }
            catch (Exception)
            {
                MessageBox.Show("JMBG mora da bude broj od 13 cifara");
                return false;
            }

            try
            {
                putnik.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd/MM/yyyy", null); 
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravan unos datuma!");
                return false;
            }

            putnik.KontaktTelefon = txtKontaktTelefon.Text;
            if(string.IsNullOrEmpty(putnik.KontaktTelefon))
            {
                MessageBox.Show("Unesite kontakt telefon!");
                return false;
            }


            Object rezultat = komunikacija.ZapamtiPutnika(putnik);

            if (rezultat==null)
            {
                MessageBox.Show("Sistem ne moze da zapamti putnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio putnika!");
                return true;
            }
        }

        internal static void Kraj()
        {
            komunikacija.Kraj();
            komunikacija = null; //da bi se ponovnim povezivanjem na server napravila nova
        }

        internal static bool PronadjiZaposlenog(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            zaposleni = new Zaposleni();
            zaposleni.KorisnickoIme = txtKorisnickoIme.Text;
            zaposleni.KorisnickaLozinka = txtLozinka.Text;

            //provera da li postoji u bazi - prosledujem serveru
            zaposleni = komunikacija.PronadjiZaposlenog(zaposleni) as Zaposleni;

            if (zaposleni==null)
            {
                MessageBox.Show("Sistem nije pronašao zaposlenog sa unetim podacima");
                return false;
            } 
            else
            {
                MessageBox.Show("Prijava na sistem je uspešna!");
                return true;
            }
        }
    }
}
