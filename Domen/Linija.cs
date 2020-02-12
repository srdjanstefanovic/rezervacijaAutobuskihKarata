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
    public class Linija : OpstiDomenskiObjekat
    {
        int id;
        string nazivPrevoznika;
        DateTime vremePolaska;
        DateTime vremeDolaska;
        string trajanjePuta;
        int raspoloziviBrojMesta;
        Stanica pocetnaStanica;
        Stanica krajnjaStanica;

        public override string ToString()
        {
            return pocetnaStanica.Grad + " - " + krajnjaStanica.Grad + " " + vremePolaska.ToString("dd/MM/yyyy HH:mm") + " -> " + vremeDolaska.ToString("HH:mm");
        }


        public int Id { get => id; set => id = value; }
        public string NazivPrevoznika { get => nazivPrevoznika; set => nazivPrevoznika = value; }
        public DateTime VremePolaska { get => vremePolaska; set => vremePolaska = value; }
        public DateTime VremeDolaska { get => vremeDolaska; set => vremeDolaska = value; }
        public string TrajanjePuta { get => trajanjePuta; set => trajanjePuta = value; }
        public int RaspoloziviBrojMesta { get => raspoloziviBrojMesta; set => raspoloziviBrojMesta = value; }
        public Stanica PocetnaStanica { get => pocetnaStanica; set => pocetnaStanica = value; }
        public Stanica KrajnjaStanica { get => krajnjaStanica; set => krajnjaStanica = value; }

        //ODO

        [Browsable(false)]
        public string nazivTabele => "Linija";
        [Browsable(false)]
        public string primarniKljuc => "LinijaID";
        [Browsable(false)]
        public string uslovPrimarni => "LinijaID=" + Id;
        [Browsable(false)]
        public string Uslov="";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => $"RaspoloziviBrojMesta = {RaspoloziviBrojMesta}";
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Linija l = new Linija();
            l.Id = Convert.ToInt32(red["LinijaID"]);
            l.NazivPrevoznika = red["NazivPrevoznika"].ToString();
            l.VremePolaska = Convert.ToDateTime(red["VremePolaska"]);
            l.VremeDolaska = Convert.ToDateTime(red["VremeDolaska"]);
            l.TrajanjePuta = red["TrajanjePuta"].ToString();
            l.RaspoloziviBrojMesta = Convert.ToInt32(red["RaspoloziviBrojMesta"]);
            l.PocetnaStanica = new Stanica();
            l.PocetnaStanica.Id = Convert.ToInt32(red["StanicaIDPocetna"]);
            l.KrajnjaStanica = new Stanica();
            l.KrajnjaStanica.Id = Convert.ToInt32(red["StanicaIDKrajnja"]);

            return l;

        }
    }
}
