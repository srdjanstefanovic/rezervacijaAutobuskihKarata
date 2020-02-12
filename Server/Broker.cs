using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlTransaction transakcija;

        public static Broker instanca;

        public static Broker DajSesiju()
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }

        public void OtvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=LAPTOP-POLUPNK4\SQLEXPRESS;Initial Catalog=RezervacijaAutobuskihKarata;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce uspostaviti konekciju!");
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                MessageBox.Show("Zapocinjanje transakcije je neuspesno!");
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno ponistavanje transakcije!");
            }
        }

        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesna potvrda transakcije");
            }
        }


        public List<OpstiDomenskiObjekat> VratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();

                // pravim novu tabelu u koju prepisujem sadrzaj Citaca
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pomocni = odo.Procitaj(red);
                    lista.Add(pomocni);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac!=null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> VratiSveZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;   
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                
                DataTable tabela = new DataTable();
                tabela.Load(citac);

                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pomocni = odo.Procitaj(red);
                    lista.Add(pomocni);
                }

                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public OpstiDomenskiObjekat VratiZaUslovPrimarni (OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);

                DataRow red;
                if (tabela.Rows.Count==0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.Procitaj(red);
                
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public OpstiDomenskiObjekat VratiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            //koristim npr. pri login-u; kada treba da se podudaraju i korisnicko ime i sifra
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(citac);

                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.Procitaj(red);

            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int IzmeniUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri radu sa bazom");
            }
        }

        public int IzmeniUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena + " WHERE " + odo.uslovOstalo;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri radu sa bazom");
            }
        }

        public int Sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.nazivTabele + " " +odo.unos;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri radu sa bazom");
            }
        }

        public int ObrisiZaUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri radu sa bazom");
            }
        }

        public int ObrisiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri radu sa bazom");
            }
        }

        public int VratiSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT MAX(" + odo.primarniKljuc +") FROM " + odo.nazivTabele;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                Object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else return Convert.ToInt32(o) + 1;
            }
            catch (Exception)
            {

                throw new Exception("Greska pri radu sa bazom");
            }
        }

    }
}
