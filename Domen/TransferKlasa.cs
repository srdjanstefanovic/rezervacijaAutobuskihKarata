using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj = 1,
        PronadjiZaposlenog = 2,
        KreirajPutnika = 3,
        ZapamtiPutnika = 4,
        UcitajSvePutnike = 5,
        PretragaPutnika = 6,
        UcitajPutnika = 7,
        ObrisiPutnika = 8,
        UcitajSveLinije = 9,
        KreirajRezervaciju = 10,
        ZapamtiRezervaciju = 11,
        ObrisiRezervaciju = 12,
        UcitajRezervaciju = 13,
        PretrazivanjeRezervacija = 14
    }

    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
