using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class KreirajRezervaciju : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = new Rezervacija();
            r.Id = Broker.DajSesiju().VratiSifru(r);
            Broker.DajSesiju().Sacuvaj(r);
            return r;
        }
    }
}
