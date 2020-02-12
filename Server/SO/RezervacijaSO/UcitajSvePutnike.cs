using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class UcitajSvePutnike : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
           

            return Broker.DajSesiju().VratiSve(odo).
                OfType<Putnik>().ToList<Putnik>();
        }
    }
}
