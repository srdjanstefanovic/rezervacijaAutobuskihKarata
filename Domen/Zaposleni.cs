using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zaposleni : OpstiDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;
        string korisnickoIme;
        string korisnickaLozinka;

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string KorisnickaLozinka { get => korisnickaLozinka; set => korisnickaLozinka = value; }


        [Browsable(false)]
        public string nazivTabele => "Zaposleni";
        [Browsable(false)]
        public string primarniKljuc => "ZaposleniID";
        [Browsable(false)]
        public string uslovPrimarni => "ZaposleniID="+Id;
        [Browsable(false)]
        public string uslovOstalo => " KorisnickoIme='"+KorisnickoIme+"' and KorisnickaLozinka='"+KorisnickaLozinka+"'";
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Zaposleni z = new Zaposleni();
            z.Id = Convert.ToInt32(red["ZaposleniID"]);
            z.Ime = red["Ime"].ToString();
            z.Prezime = red["Prezime"].ToString();
            z.KorisnickoIme = red["KorisnickoIme"].ToString();
            z.KorisnickaLozinka = red["KorisnickaLozinka"].ToString();

            return z;
        }
    }
}
