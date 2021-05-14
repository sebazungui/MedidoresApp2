using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocketUtils;

namespace MedidoresApp.Hilos
{
    class HiloCliente
    {
        private ClienteSocket clienteSocket;

        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {
            string prueba;
            do
            {
                clienteSocket.Escribir("Ingrese nombre");
                prueba = clienteSocket.Leer().Trim();
            } while (prueba == string.Empty);
        }
    }
}
