using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket soket;
        public static List<NetworkStream> listaTokova = new List<NetworkStream>();
        public static bool KrajServera = false;

        public bool PokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(endPoint);

                ThreadStart ts = Osluskuj;
                new Thread(ts).Start();

                KrajServera = false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void Osluskuj()
        {
            try
            {
                while (true)
                {
                    soket.Listen(9);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    listaTokova.Add(tok);
                    new NitKlijenta(tok);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                KrajServera = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
