using Examen;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string nombre = "Elvis Alas";
            string numeroCuenta = "T32321121";
            string email = "ElvisAlasEcheverry@gmail.com";
            string nombreClase = "Programacion II";
            string horaClase = "18:30 - 19:30";
            string nombreCatedratico = "Ing. Roger Ivan Gurdian Castillo";


            Console.WriteLine("Ingrese las notas del Alumno ");
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            Clase clase = new Clase(nombre, numeroCuenta, email, nombreClase, horaClase, nombreCatedratico);
            clase.MostrarClase();

            Promedio promedio = new Promedio(nota1, nota2, nota3);
            Console.WriteLine(promedio.MostrarPromedio(nota1, nota2, nota3));

            double resultadoPromedio = promedio.CalcularPromedio();
            Console.WriteLine("Promedio utilizando el metodo CalcularPromedio sin parametros: " + resultadoPromedio.ToString("0.00"));

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
