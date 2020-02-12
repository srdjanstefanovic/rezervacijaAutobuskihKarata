using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.PutnikSO
{
    public class UcitajPutnika : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            
            return Broker.DajSesiju().VratiZaUslovPrimarni(odo) as Putnik;
            /* kad prikazujem detalje o putniku, sve vec imam u dataGridView-u, pa ne moram ponovo da idem do baze
             * Putnik p = odo as Putnik;
            return p;*/
        }
    }
}
