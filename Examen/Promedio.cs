using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Promedio : PromedioInterfaz
    {
        private double nota1, nota2, nota3;

        public Promedio(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public string MostrarPromedio()
        {
            return "Promedio no calculado.";
        }

        public string MostrarPromedio(double nota1, double nota2, double nota3)
        {
            double promedio = CalcularPromedio(nota1, nota2, nota3);
            return "Promedio utilizando el metodo CalcularPromedio con parametros: " + promedio.ToString("0.00");
        }

        public double CalcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
