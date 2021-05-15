using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class LecturaDALArchivos : ILecturaDAL
    {
        private LecturaDALArchivos()
        {

        }

        private static ILecturaDAL instancia;

        public static ILecturaDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new LecturaDALArchivos();
            return instancia;
        }


        private string archivoTrafico = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + "traficos.txt";

        private string archivoConsumo = Directory.GetCurrentDirectory()
            + Path.DirectorySeparatorChar + "consumos.txt";






        public void RegistrarLecturaConsumo(Lectura l)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivoConsumo, true))
                {
                    
                    writer.WriteLine(l);
                    writer.Flush();               
                }
            }catch(IOException ex)
            {

            }
        }


        public void RegistrarLecturaTrafico(Lectura l)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivoTrafico, true))
                {
                    writer.WriteLine(l);
                    writer.Flush();
                }
            }
            catch (IOException ex)
            {

            }
        }
    }
}
