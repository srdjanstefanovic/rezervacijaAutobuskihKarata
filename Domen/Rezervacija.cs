using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Valuta { RSD=1,EUR=2}

    [Serializable]
    public class Rezervacija : OpstiDomenskiObjekat
    {
        int id;
        DateTime datumRezervacije;
        double ukupanIznos;
        Valuta valuta;
        Zaposleni zaposleni;
        Putnik putnik;
        BindingList<StavkaRezervacije> listaStavki;

        public int Id { get => id; set => id = value; }
        public DateTime DatumRezervacije { get => datumRezervacije; set => datumRezervacije = value; }
        public double UkupanIznos { get => ukupanIznos; set => ukupanIznos = value; }
        public Valuta Valuta { get => valuta; set => valuta = value; }
        [Browsable(false)]
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        [Browsable(false)]
        public Putnik Putnik { get => putnik; set => putnik = value; }
        
        public BindingList<StavkaRezervacije> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public Rezervacija()
        {
            listaStavki = new BindingList<StavkaRezervacije>();
        }


        //ODO

        [Browsable(false)]
        public string nazivTabele => "Rezervacija";
        [Browsable(false)]
        public string primarniKljuc => "RezervacijaID";
        [Browsable(false)]
        public string uslovPrimarni => "RezervacijaID="+Id;
        [Browsable(false)]
        public string Uslov="";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " DatumRezervacije='"+DatumRezervacije.ToString("yyyy-MM-dd")+"', UkupanIznos="+UkupanIznos+", Valuta="+(int)Valuta+", ZaposleniID="+Zaposleni.Id+", PutnikID="+Putnik.Id+"";
        [Browsable(false)]
        public string unos => "(RezervacijaID) values ("+Id+")";

        

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Rezervacija r = new Rezervacija();
            r.Id = Convert.ToInt32(red["RezervacijaID"]);
            r.DatumRezervacije = Convert.ToDateTime(red["DatumRezervacije"]);
            r.UkupanIznos = Convert.ToDouble(red["UkupanIznos"]);
            r.Valuta = (Valuta)Convert.ToInt32(red["Valuta"]);
            r.Zaposleni = new Zaposleni();
            r.Zaposleni.Id = Convert.ToInt32(red["ZaposleniID"]);
            r.Putnik = new Putnik();
            r.Putnik.Id = Convert.ToInt32(red["PutnikID"]);

            return r;
        }
    }
}
