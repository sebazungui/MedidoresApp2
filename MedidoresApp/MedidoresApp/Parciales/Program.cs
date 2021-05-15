using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresApp
{
    public partial class Program
    {
        static ILecturaDAL dal = LecturaDALFactory.CreateDal();

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Ingrese opcion del menu:");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    IngresarLectura();
                    break;
                case "2":
                    MostrarLecturas();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese opcion Válida");
                    break;
            }
            return continuar;
        }

        private static void MostrarLecturas()
        {
            throw new NotImplementedException();
        }

        private static void IngresarLectura()
        {
            string fecha, valor, unidadMedida;
            int tipo;
            do
            {
                Console.WriteLine("Ingrese fecha:");
                fecha = Console.ReadLine().Trim();

            } while (fecha == string.Empty);

            do
            {
                Console.WriteLine("Ingrese Valor:");
                valor = Console.ReadLine().Trim();
            } while (valor == string.Empty);

            do
            {
                Console.WriteLine("Ingrese detalle:");
                unidadMedida = Console.ReadLine().Trim();
            } while (unidadMedida == string.Empty);

            do
            {
                Console.WriteLine("Ingrese detalle:");
                tipo = Convert.ToInt32(Console.ReadLine().Trim());
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

        }
    }
}
