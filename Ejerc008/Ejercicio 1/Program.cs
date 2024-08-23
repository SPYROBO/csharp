using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la cantidad de alumnos a colocar");
            int cantidad_alum = Convert.ToInt32(Console.ReadLine());
            float prom = 0;
            int pos = 0;
            int total_aprobadas = 0;
            bool verificar = true;
            int mayor_aprobadas = 0;
            alumnos[] Objalumno = new alumnos[cantidad_alum];
            for (int c = 0; c < cantidad_alum; c++) Objalumno[c] = new alumnos();
            for (int i = 0; i < Objalumno.Length; i++)
            {
                Console.WriteLine("Nombre del alumno {0}",(i+1));
                Objalumno[i].nombre = Console.ReadLine();
                Console.WriteLine("Apellido del alumno {0}", (i + 1));
                Objalumno[i].apellido = Console.ReadLine();
                Console.WriteLine("Edad del alumno {0}", (i + 1));
                Objalumno[i].edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Materias aprobadas del alumno {0}", (i + 1));
                Objalumno[i].cant_aprobadas = Convert.ToInt32(Console.ReadLine());
                prom += Objalumno[i].edad;
                total_aprobadas += Objalumno[i].cant_aprobadas;
            }
            int menor = Objalumno[0].edad;
            int mayor = Objalumno[0].edad;
            for (int i = 0; i < cantidad_alum; i++) Objalumno[i].listar(i);
            for (int i = 0; i < cantidad_alum; i++)
            {
                if (menor > Objalumno[i].edad) menor = Objalumno[i].edad;
                if (mayor < Objalumno[i].edad)
                {
                    mayor = Objalumno[i].edad;
                    pos = i;
                    mayor_aprobadas = Objalumno[i].cant_aprobadas;
                }
            }
            for (int i = 0;i < cantidad_alum; i++)
            {
                if (mayor_aprobadas < Objalumno[i].cant_aprobadas && mayor == Objalumno[pos].edad)
                {
                    verificar = false;
                }
            }
            Objalumno[cantidad_alum - 1].promedio_edad((prom / cantidad_alum));
            Objalumno[cantidad_alum - 1].menor(menor);
            Objalumno[cantidad_alum - 1].mayor(mayor);
            Objalumno[cantidad_alum - 1].aprobadas(total_aprobadas, (total_aprobadas / cantidad_alum));
            Objalumno[cantidad_alum - 1].mayor_aprobadas(verificar);
        }
        public class alumnos
        {
            // Constructor
            public alumnos() { }

            // Método
            public void listar(int c)
            {
                Console.WriteLine("{0}) {1} {2} tiene {3} años y tiene {4} materias aprobadas", (c+1), nombre, apellido, edad, cant_aprobadas);
            }
            public void promedio_edad(float c)
            {
                Console.WriteLine("La edad promedio del curso es {0}", c);
            }
            public void menor(int menor)
            {
                Console.WriteLine("La menor edad del curso es de {0} años", menor);
            }
            public void mayor(int mayor)
            {
                Console.WriteLine("La mayor edad del curso es de {0} años", mayor);
            }
            public void aprobadas(int cant, float prom)
            {
                Console.WriteLine("La cantidad total de materias aprobadas es de {0} materias", cant);
                Console.WriteLine("La cantidad promedio de materias aprobadas por alumno es de {0} materias", prom);
            }
            public void mayor_aprobadas(bool v)
            {
                if (v == true)
                {
                    Console.WriteLine("El alumno mayor es el que mayor cantidad de materias aprobadas tiene");
                }
                else
                {
                    Console.WriteLine("El alumno mayor no es el que mayor cantidad de materias aprobadas tiene");
                }
            }

            // Atributos
            public string nombre;
            public string apellido;
            public int edad;
            public int cant_aprobadas;

        }
    }
}
