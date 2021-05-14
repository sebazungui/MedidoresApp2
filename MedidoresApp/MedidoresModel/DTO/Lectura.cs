using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura
    {
        private DateTime fecha;
        private string valor;
        private int tipo;
        private string unidadMedida;
        List<int> nroMedidorTrafico;
        List<int> nroMedidorConsumo;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public List<int> NroMedidorTrafico { get => nroMedidorTrafico; set => nroMedidorTrafico = value; }
        public List<int> NroMedidorConsumo { get => nroMedidorConsumo; set => nroMedidorConsumo = value; }
    }
}
