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
    public class StavkaRezervacije : OpstiDomenskiObjekat
    {
        int rezervacijaID;
        int redniBroj;
        double cena;
        Linija linija;

        [Browsable(false)]
        public int RezervacijaID { get => rezervacijaID; set => rezervacijaID = value; }
        [DisplayName("R. br.")]
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        public double Cena { get => cena; set => cena = value; }
        public Linija Linija { get => linija; set => linija = value; }
        



        //ODO

        [Browsable(false)]
        public string nazivTabele => "StavkaRezervacije";
        [Browsable(false)]
        public string primarniKljuc => "";
        [Browsable(false)]
        public string uslovPrimarni => "";
        [Browsable(false)]
        public string Uslov = "";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => " values (" + RezervacijaID + ", "+RedniBroj+", "+Cena+", "+Linija.Id+")";


        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            StavkaRezervacije sr = new StavkaRezervacije();

            sr.RezervacijaID = Convert.ToInt32(red["RezervacijaID"]);
            sr.RedniBroj = Convert.ToInt32(red["RedniBroj"]);
            sr.Cena = Convert.ToDouble(red["Cena"]);
            sr.Linija = new Linija();
            sr.Linija.Id = Convert.ToInt32(red["LinijaID"]);

            return sr;
        }
    }
}
