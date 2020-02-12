using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class UcitajRezervaciju : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = Broker.DajSesiju().VratiZaUslovPrimarni(odo) as Rezervacija;

            r.Zaposleni = Broker.DajSesiju().VratiZaUslovPrimarni(r.Zaposleni) as Zaposleni;
            r.Putnik = Broker.DajSesiju().VratiZaUslovPrimarni(r.Putnik) as Putnik;

            StavkaRezervacije sr = new StavkaRezervacije();
            sr.Uslov = " RezervacijaID=" + r.Id;

            List<StavkaRezervacije> lista = Broker.DajSesiju().VratiSveZaUslovOstalo(sr).
                OfType<StavkaRezervacije>().ToList<StavkaRezervacije>();

            foreach (StavkaRezervacije stavka in lista)
            {
                stavka.Linija = Broker.DajSesiju().VratiZaUslovPrimarni(stavka.Linija) as Linija;
                stavka.Linija.PocetnaStanica = Broker.DajSesiju().VratiZaUslovPrimarni(stavka.Linija.PocetnaStanica) as Stanica;
                stavka.Linija.KrajnjaStanica = Broker.DajSesiju().VratiZaUslovPrimarni(stavka.Linija.KrajnjaStanica) as Stanica;
                r.ListaStavki.Add(stavka);
            }

            return r;
        }
    }
}
