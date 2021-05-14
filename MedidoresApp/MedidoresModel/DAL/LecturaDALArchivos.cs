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


        public List<Lectura> obtenerLecturasConsumos()
        {
            List<Lectura> lecturas = new List<Lectura>();
            try
            {
                using(StreamReader reader = new StreamReader(archivoConsumo))
                {
                    string texto = null;
                    do
                    {
                        texto = reader.ReadLine();
                        if(texto != null)
                        {
                            string[] textoArray = texto.Split('|');
                            Lectura l = new Lectura()
                            {
                                // Corregir el parseo
                                NroMedidorConsumo = textoArray[0],
                                Fecha = textoArray[1],
                                Valor = textoArray[2],
                                Tipo = textoArray[3],
                                UnidadMedida = textoArray[4]
                            };
                            lecturas.Add(l);
                        }
                    } while (texto != null);
                }
            }catch(IOException ex)
            {
                lecturas = null;
            }

            return lecturas;
        }

        public List<Lectura> obtenerLecturasTrafico()
        {
            List<Lectura> lecturas = new List<Lectura>();
            try
            {
                using (StreamReader reader = new StreamReader(archivoTrafico))
                {
                    string texto = null;
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto != null)
                        {
                            string[] textoArray = texto.Split('|');
                            Lectura l = new Lectura()
                            {
                                // Corregir el parseo
                                NroMedidorTrafico = textoArray[0],
                                Fecha = textoArray[1],
                                Valor = textoArray[2],
                                Tipo = textoArray[3],
                                UnidadMedida = textoArray[4]
                            };
                            lecturas.Add(l);
                        }
                    } while (texto != null);
                }
            }
            catch (IOException ex)
            {
                lecturas = null;
            }

            return lecturas;
        }

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
