using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.RezervacijaSO
{
    public class UcitajSveLinije : OpstaSistemskaOperacija
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            List<Linija> lista = new List<Linija>();
            Linija linija = odo as Linija;
            linija.Uslov = " VremePolaska > '" + DateTime.Now+"'";
            lista = Broker.DajSesiju().VratiSveZaUslovOstalo(linija).OfType<Linija>().ToList<Linija>();
            //lista = Broker.DajSesiju().VratiSve(odo).OfType<Linija>().ToList<Linija>();

            foreach (Linija l in lista)
            {
                
                l.PocetnaStanica = (Stanica)Broker.DajSesiju().VratiZaUslovPrimarni(l.PocetnaStanica);

                
                l.KrajnjaStanica = (Stanica)Broker.DajSesiju().VratiZaUslovPrimarni(l.KrajnjaStanica);
            }

            return lista;
        }
    }
}
