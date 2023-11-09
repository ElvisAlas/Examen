using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Alumno
    {
        public string Nombre { get; set; }
        public string NumeroCuenta { get; set; }
        public string Email { get; set; }

        public Alumno(string nombre, string numeroCuenta, string email)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            Email = email;
        }

        


        public void MostrarAlumno()
        {
          
            Console.WriteLine("Datos del Alumno");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Número de Cuenta: " + NumeroCuenta);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("");

        }

    }
}
