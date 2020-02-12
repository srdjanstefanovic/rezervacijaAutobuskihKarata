using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class ObrisiRezervaciju : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            Broker.DajSesiju().ObrisiZaUslovPrimarni(odo);

            foreach (StavkaRezervacije stavka in r.ListaStavki)
            {
                Linija l = Broker.DajSesiju().VratiZaUslovPrimarni(stavka.Linija) as Linija;
                l.RaspoloziviBrojMesta++;
                Broker.DajSesiju().IzmeniUslovPrimarni(l);
            }

            return true;
        }
    }
}
