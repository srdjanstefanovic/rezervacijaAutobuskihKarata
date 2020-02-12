using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Server.SO.PutnikSO;
using Server.SO.RezervacijaSO;
using Server.SO.ZaposleniSO;

namespace Server
{
    class NitKlijenta
    {
        NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = Obradi;
            new Thread(ts).Start();
        }

        void Obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    if (Server.KrajServera)
                    {
                        transfer.Operacija = Operacije.Kraj;
                    }

                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiZaposlenog:
                            PronadjiZaposlenog pz = new PronadjiZaposlenog();
                            //izvrsavam "opstu" SO jer mi ona kreira konekciju sa bazom i poziva konkretnu SO (u ovom slucaju so PronadjiZaposlenog jer sam nju istancirao)
                            transfer.Rezultat = pz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajPutnika:
                            KreirajPutnika kp = new KreirajPutnika();
                            transfer.Rezultat = kp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiPutnika:
                            ZapamtiPutnika zp = new ZapamtiPutnika();
                            transfer.Rezultat = zp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajSvePutnike:
                            UcitajSvePutnike usp = new UcitajSvePutnike();
                            transfer.Rezultat = usp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretragaPutnika:
                            PretragaPutnika pp = new PretragaPutnika();
                            transfer.Rezultat = pp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajPutnika:
                            UcitajPutnika up = new UcitajPutnika();
                            transfer.Rezultat = up.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiPutnika:
                            ObrisiPutnika op = new ObrisiPutnika();
                            transfer.Rezultat = op.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajSveLinije:
                            UcitajSveLinije usl = new UcitajSveLinije();
                            transfer.Rezultat = usl.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajRezervaciju:
                            KreirajRezervaciju kr = new KreirajRezervaciju();
                            transfer.Rezultat = kr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiRezervaciju:
                            ZapamtiRezervaciju zr = new ZapamtiRezervaciju();
                            transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiRezervaciju:
                            ObrisiRezervaciju or = new ObrisiRezervaciju();
                            transfer.Rezultat = or.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajRezervaciju:
                            UcitajRezervaciju ur = new UcitajRezervaciju();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretrazivanjeRezervacija:
                            PretrazivanjeRezervacija pr = new PretrazivanjeRezervacija();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            
                            //saljem klijentu informaciju da je server prekinuo/zavrsio rad
                            formater.Serialize(tok, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.listaTokova.Remove(tok);
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
