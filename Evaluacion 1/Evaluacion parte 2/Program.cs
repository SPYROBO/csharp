using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string i = "si";
            alumnos alumno = new alumnos();
            while (i == "si" || i == "SI" || i == "Si" || i == "sI") {
                Console.WriteLine("Indique el nombre del alumno");
                alumno.nombre = Console.ReadLine();
                Console.WriteLine("Indique el apellido del alumno");
                alumno.apellido = Console.ReadLine();
                Console.WriteLine("Indique el DNI del alumno");
                alumno.dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indique el peso del alumno");
                alumno.peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coloque el año de nacimiento del alumno");
                alumno.año = Convert.ToInt32(Console.ReadLine());
                alumno.par();
                alumno.mostrar();
                Console.WriteLine("¿Quiere añadir a otro alumno? Indique con si");
                i = Console.ReadLine();
                c++;
            }
            Console.WriteLine("Cantidad de alumnos añadidos: " + c);
        }
        public class alumnos
        {
            public alumnos()
            {

            }
            //Atributos 
            public string apellido;
            public string nombre;
            public int dni;
            public double peso;
            public int año;
            //Métodos
            public void par()
            {
                if (dni % 2 == 0)
                {
                    Console.WriteLine("El DNI es par");
                }
                else
                {
                    Console.WriteLine("El DNI es impar");
                }
            }
            public void mostrar()
            {
                Console.WriteLine("El nombre completo del alumno es: {0} {1}", nombre, apellido);
                Console.WriteLine("Nació en el año {0}, pesa {1} kilos y su DNI es {2}", año, peso, dni);
            }
        }
    }
}
