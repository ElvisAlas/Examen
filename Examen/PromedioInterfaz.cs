using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal interface PromedioInterfaz
    {
        string MostrarPromedio();
        string MostrarPromedio(double nota1, double nota2, double nota3);
        double CalcularPromedio();
        double CalcularPromedio(double nota1, double nota2, double nota3);
    }
}
