using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.PutnikSO
{
    public class ObrisiPutnika : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.DajSesiju().ObrisiZaUslovPrimarni(odo);
        }
    }
}
