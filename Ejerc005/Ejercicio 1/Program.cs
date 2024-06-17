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

            //Instancias de las clases
            persona ObjPerso1 = new persona();
            persona ObjPerso2 = new persona();
            persona ObjPerso3 = new persona();

            //Objeto 1
            Console.WriteLine("Coloque la información de la persona 1");
            Console.WriteLine("Edad");
            ObjPerso1.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre");
            ObjPerso1.nombre = Console.ReadLine();
            Console.WriteLine("Apellido");
            ObjPerso1.apellido = Console.ReadLine();

            //Objeto 2
            Console.WriteLine("Coloque la información de la persona 2");
            Console.WriteLine("Edad");
            ObjPerso2.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre");
            ObjPerso2.nombre = Console.ReadLine();
            Console.WriteLine("Apellido");
            ObjPerso2.apellido = Console.ReadLine();

            //Objeto 3
            Console.WriteLine("Coloque la información de la persona 3");
            Console.WriteLine("Edad");
            ObjPerso3.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre");
            ObjPerso3.nombre = Console.ReadLine();
            Console.WriteLine("Apellido");
            ObjPerso3.apellido = Console.ReadLine();

            //Ejecutar Objetos
            ObjPerso1.calcular(1);
            ObjPerso2.calcular(2);
            ObjPerso3.calcular(3);

            //Promedio
            int promedio = (ObjPerso1.edad + ObjPerso2.edad + ObjPerso3.edad) / 3;
            ObjPerso3.promedio(promedio);
        }
        //Nueva clase
        public class persona
        {
            //Constructor
            public persona()
            {

            }
            //Atributos
            public string nombre;
            public string apellido;
            public int edad;

            //Métodos 
            public void calcular(int contador)
            {
                Console.WriteLine("El nombre completo de la persona {0} es {1} {2} y su edad es {3}",contador, nombre, apellido, edad);
            }
            public void promedio(int promedio)
            {
                Console.WriteLine("Promedio : {0}", promedio);
            }
        }
    }
}
