using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class ZapamtiRezervaciju : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Rezervacija r = odo as Rezervacija;
            Broker.DajSesiju().IzmeniUslovPrimarni(r);

            //moram da zapamtim i stavke kao slab objekat
            StavkaRezervacije sr = new StavkaRezervacije();

            //kako ne bi doslo do dupliranja/brisanja stavki u bazi, pre nego sto dodam nove prvo brisem sve stavke sa tim ID-em rezervacije u bazi, pa dodajem sve ove i dgv (listeStavki)
            sr.Uslov = " RezervacijaID=" + r.Id;
            Broker.DajSesiju().ObrisiZaUslovOstalo(sr);

            foreach (StavkaRezervacije stavka in r.ListaStavki)
            {
                
                stavka.RezervacijaID = r.Id;
                //kod StavkaRezervacija, sacuvaj mi odmah cuva ceo red, ne samo primarni kljuc
                Broker.DajSesiju().Sacuvaj(stavka);
                /*stavka.Uslov = " RezervacijaID=" + r.Id;
                Broker.DajSesiju().IzmeniUslovOstalo(stavka);*/

                Linija l = Broker.DajSesiju().VratiZaUslovPrimarni(stavka.Linija) as Linija;
                l.RaspoloziviBrojMesta--;
                Broker.DajSesiju().IzmeniUslovPrimarni(l);
            }
            
            return true;
        }
    }
}
