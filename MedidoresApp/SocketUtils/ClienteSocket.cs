using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketUtils
{
    public class ClienteSocket
    {
        private Socket comCliente;
        private StreamReader reader;
        private StreamWriter writer;

        public ClienteSocket(Socket comCliente)
        {
            this.comCliente = comCliente;
        }
    }
}
