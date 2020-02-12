using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Pol { Muski=1,Zenski=2}

    [Serializable]
    public class Putnik : OpstiDomenskiObjekat
    {
        int id;
        string ime;
        string prezime;
        Pol pol;
        string jmbg;
        DateTime datumRodjenja;
        string kontaktTelefon;

        public override string ToString()
        {
            return ime +" "+prezime+ " ["+jmbg+"]"; 
        }

        [DisplayName("Šifra")]
        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public Pol Pol { get => pol; set => pol = value; }
        [DisplayName("JMBG")]
        public string Jmbg { get => jmbg; set => jmbg = value; }
        [DisplayName("Datum rođenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [DisplayName("Telefon")]
        public string KontaktTelefon { get => kontaktTelefon; set => kontaktTelefon = value; }



        //ODO

        [Browsable(false)]
        public string nazivTabele => "Putnik";
        [Browsable(false)]
        public string primarniKljuc => "PutnikID";
        [Browsable(false)]
        public string uslovPrimarni => "PutnikID=" + Id;
        [Browsable(false)]
        public string Uslov = "";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Ime='"+Ime+"', Prezime='"+Prezime+"', Pol="+(int)Pol+", JMBG='"+Jmbg+"', DatumRodjenja='"+DatumRodjenja.ToString("yyyy-MM-dd")+"', KontaktTelefon='"+KontaktTelefon+"'";
        [Browsable(false)]
        public string unos => "(PutnikID) values ("+Id+")";

       
        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Putnik p = new Putnik();
            p.Id = Convert.ToInt32(red["PutnikID"]);
            p.Ime = red["Ime"].ToString();
            p.Prezime = red["Prezime"].ToString();
            p.Pol = (Pol)Convert.ToInt32(red["Pol"]);
            p.Jmbg = red["JMBG"].ToString();
            p.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            p.KontaktTelefon = red["KontaktTelefon"].ToString();

            return p;
        }
    }
}
