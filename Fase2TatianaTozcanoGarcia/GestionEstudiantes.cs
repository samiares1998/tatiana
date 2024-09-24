using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2TatianaTozcanoGarcia
{
    internal class GestionEstudiantes
    {

        public string Identificacion {  get; set; }
        public string NombreCompleto { get; set; }
        public string Genero { get; set; }
        public string Instrumento { get; set; }
        public int NumeroClases { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CostoPorClase { get; set; }

        //Metodo para calcular el costo total del curso

        public decimal CalcularCostoTotal()
        {
            return NumeroClases * CostoPorClase;
        }

    }
}
