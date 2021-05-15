using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DAL;
using MedidoresModel.DTO;
using SocketUtils;

namespace MedidoresApp.Hilos
{
    class HiloCliente
    {
        private ClienteSocket clienteSocket;
        private ILecturaDAL dal = LecturaDALFactory.CreateDal();
        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }

        public void Ejecutar()
        {
            string fecha, valor, unidadMedida;
            int tipo;
            do
            {
                clienteSocket.Escribir("Ingrese fecha:");
                fecha = clienteSocket.Leer().Trim();

            } while (fecha == string.Empty);

            do
            {
                clienteSocket.Escribir("Ingrese Valor:");
                valor = clienteSocket.Leer().Trim();
            } while (valor == string.Empty);

            do
            {
                clienteSocket.Escribir("Ingrese detalle:");
                unidadMedida = clienteSocket.Leer().Trim();
            } while (unidadMedida == string.Empty);

            do
            {
                clienteSocket.Escribir("Ingrese detalle:");
                tipo = Convert.ToInt32(clienteSocket.Leer().Trim());
            } while (tipo.Equals(0));

            Lectura l = new Lectura()
            {
                Fecha = fecha,
                UnidadMedida = unidadMedida,
                Valor = valor,
                Tipo = tipo
            };
            lock (dal)
            {
                dal.RegistrarLecturaConsumo(l);
            }            
            clienteSocket.CerrarConexion();
        }
    }
}


