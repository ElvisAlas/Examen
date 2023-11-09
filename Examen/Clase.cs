using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Clase : Alumno
    {
        public string NombreClase { get; set; }
        public string HoraClase { get; set; }
        public string NombreCatedratico { get; set; }

        public Clase(string nombre, string numeroCuenta, string email, string nombreClase, string horaClase, string nombreCatedratico)
            : base(nombre, numeroCuenta, email)
        {
            NombreClase = nombreClase;
            HoraClase = horaClase;
            NombreCatedratico = nombreCatedratico;
        }

        public void MostrarClase()
        {
            Console.WriteLine("");

            MostrarAlumno();
      
            Console.WriteLine("Datos de la Clase");
            Console.WriteLine("Nombre de la Clase: " + NombreClase);
            Console.WriteLine("Hora de la Clase: " + HoraClase);
            Console.WriteLine("Nombre del Catedrático: " + NombreCatedratico);
        
        }
    }
}
