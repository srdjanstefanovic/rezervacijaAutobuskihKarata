using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;
        public static bool krajK = false;

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        Object PrimiRezultat()
        {
            TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Operacija == Operacije.Kraj) krajK = true;
            return transfer.Rezultat;
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object PronadjiZaposlenog(Zaposleni z)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiZaposlenog;
            transfer.TransferObjekat = z;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object KreirajPutnika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajPutnika;
            //kada nemam ulazni paramter (operacije: UcitajSve, Kreiraj), za transferObekat koristim new TajObjekat()
            //ovako transfer zna sta je ODO -> koji je naziv tabele (iz koje tabele treba da cita podatke), koji je primatni kljuc...
            transfer.TransferObjekat = new Putnik();
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object ZapamtiPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object PretragaPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretragaPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object UcitajPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object ObrisiPutnika(Putnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiPutnika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object KreirajRezervaciju()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajRezervaciju;
            transfer.TransferObjekat = new Rezervacija();
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object ZapamtiRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object ObrisiRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object UcitajRezervaciju(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajRezervaciju;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object PretrazivanjeRezervacija(Rezervacija r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretrazivanjeRezervacija;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object UcitajSvePutnike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSvePutnike;
            transfer.TransferObjekat = new Putnik();
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }

        public Object UcitajSveLinije()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSveLinije;
            transfer.TransferObjekat = new Linija();
            formater.Serialize(tok, transfer);

            return PrimiRezultat();
        }
    }
}
