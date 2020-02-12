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
    public class Stanica : OpstiDomenskiObjekat
    {
        //atributi

        int id;
        string grad;
        string adresa;

        public int Id { get => id; set => id = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        //ODO

        [Browsable(false)]
        public string nazivTabele => "Stanica";
        [Browsable(false)]
        public string primarniKljuc => "StanicaID";
        [Browsable(false)]
        public string uslovPrimarni => "StanicaID=" + Id;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat Procitaj(DataRow red)
        {
            Stanica s = new Stanica();
            s.Id = Convert.ToInt32(red["StanicaID"]);
            s.Grad = red["Grad"].ToString();
            s.Adresa = red["Adresa"].ToString();

            return s;
        }
    }
}
