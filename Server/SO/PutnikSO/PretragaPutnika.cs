using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.PutnikSO
{
    public class PretragaPutnika : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Putnik p = new Putnik();
            p.Uslov = " Ime is null";
            Broker.DajSesiju().ObrisiZaUslovOstalo(p);

            return Broker.DajSesiju().VratiSveZaUslovOstalo(odo).
                OfType<Putnik>().ToList<Putnik>();
            // po default-u bi bila vracena lista ODO-a, a treba mi lista Putnika
        }
    }
}
