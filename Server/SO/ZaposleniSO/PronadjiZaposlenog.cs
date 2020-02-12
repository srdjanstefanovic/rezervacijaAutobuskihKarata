using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.ZaposleniSO
{
    public class PronadjiZaposlenog : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().VratiZaUslovOstalo(odo) as Zaposleni;
        }
    }
}
