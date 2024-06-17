using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_2.Program;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancias de las clases
            rectangulo recta = new rectangulo();

            //Objeto
            Console.WriteLine("Coloque la información del rectángulo");
            Console.WriteLine("Lado 1");
            recta.lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lado 2");
            recta.lado2 = Convert.ToInt32(Console.ReadLine());
            if (recta.lado1 <= 0 || recta.lado2 <= 0)
            {
                Console.WriteLine("Los lados deben ser mayores a 0");
            }
            else if (recta.lado1 == recta.lado2)
            {
                Console.WriteLine("Esa figura es un cuadrado");
            }
            else
            {
                recta.comprobar();
            }
        }
        public class rectangulo
        {
            //Constructor
            public rectangulo()
                {

                }
            //Atributos
            public int lado1;
            public int lado2;

            //Métodos
            public void comprobar()
            {
                Console.WriteLine("Ha ingresado un rectángulo de {0} por {1}", lado1, lado2);
            }
        }
    }
}
