﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura
    {
        private string fecha;
        private string valor;
        private int tipo;
        private string unidadMedida;

        public string Fecha { get => fecha; set => fecha = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }

        public override string ToString()
        {
            return "{\"fecha\":" + fecha + ", \"valor\":\"" + valor + ", \"tipo\":\"" + tipo + ",\"unidadMedida\":\"" + unidadMedida + "\"}";
        }
    }
}
