using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo triangulo = new triangulo();
            while (triangulo.lado1 == 0)
            {
                Console.WriteLine("Defina el lado 1 que sea mayor a cero");
                triangulo.lado1 = Convert.ToInt32(Console.ReadLine());
            }
            while (triangulo.lado2 == 0)
            {
                Console.WriteLine("Defina el lado 2 que sea mayor a cero");
                triangulo.lado2 = Convert.ToInt32(Console.ReadLine());
            }
            while (triangulo.lado3 == 0)
            {
                Console.WriteLine("Defina el lado 3 que sea mayor a cero");
                triangulo.lado3 = Convert.ToInt32(Console.ReadLine());
            }
            triangulo.info();
            triangulo.recto();
            triangulo.per();
            triangulo.area();
        }
        public class triangulo
        {
            public triangulo() { }

            //Atributos
            public double lado1 = 0;
            public double lado2 = 0;
            public double lado3 = 0;

            //Métodos
            public void info()
            {
                Console.WriteLine("El lado 1 del triángulo mide {0}, el lado 2 mide {1} y el lado 3 mide {2}", lado1, lado2, lado3);
            }
            public void recto()
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    if (lado3 * lado3 + lado2 * lado2 == lado1 * lado1)
                    {
                        Console.WriteLine("Es un triángulo rectángulo");
                    }
                    else
                    {
                        Console.WriteLine("No es un triángulo rectángulo");
                    }
                }
                if (lado2 > lado1 && lado2 > lado3)
                {
                    if (lado3 * lado3 + lado1 * lado1 == lado2 * lado2)
                    {
                        Console.WriteLine("Es un triángulo rectángulo");
                    }
                    else
                    {
                        Console.WriteLine("No es un triángulo rectángulo");
                    }
                }
                if (lado3 > lado1 && lado3 > lado2)
                {
                    if (lado2 * lado2 + lado1 * lado1 == lado3 * lado3)
                    {
                        Console.WriteLine("Es un triángulo rectángulo");
                    }
                    else
                    {
                        Console.WriteLine("No es un triángulo rectángulo");
                    }
                }

            }
            public void per()
            {
                Console.WriteLine("La superficie del triángulo es de: " + (lado1 + lado2 + lado3));
            }
            public void area()
            {
                double s = (lado1 + lado2 + lado3) / 2;
                double ar = (Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3)));
                if (double.IsNaN(ar))
                {
                    Console.WriteLine("El triangulo no existe");
                }
                else
                {
                    Console.WriteLine("El area del triangulo es de: " + ar);
                }
               
            }
        }
    }
}
