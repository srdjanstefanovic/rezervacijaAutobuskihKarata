using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.PutnikSO
{
    public class KreirajPutnika : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Putnik p = new Putnik();
            p.Id = Broker.DajSesiju().VratiSifru(p);
            Broker.DajSesiju().Sacuvaj(p);
            return p;
            
        }
    }
}
