using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class PretrazivanjeRezervacija : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = new Rezervacija();
            //prvo moram da uklonim iz baze one Rezervacije sa cenom null, ako postoje, da mi ne bi i njih prikazao
            r.Uslov = " UkupanIznos is null";
            Broker.DajSesiju().ObrisiZaUslovOstalo(r);

            
            return Broker.DajSesiju().VratiSveZaUslovOstalo(odo).OfType<Rezervacija>().ToList<Rezervacija>();
        }
    }
}
