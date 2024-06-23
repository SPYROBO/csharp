using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int cant;
            double total = 0;
            Console.WriteLine("Seleccione cuantos triángulos va a ingresar:");
            cant = Convert.ToInt32(Console.ReadLine());
            
            triangulo triangulo = new triangulo();
            for (int i = 1; i <= cant; i++)
            {
                Console.WriteLine("Defina el triángulo {0}", i);
                Console.WriteLine("Defina el lado 1");
                triangulo.lado1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Defina el lado 2");
                triangulo.lado2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Defina el lado 3");
                triangulo.lado3 = Convert.ToInt32(Console.ReadLine());
                if (triangulo.lado1 == triangulo.lado2 && triangulo.lado2 == triangulo.lado3)
                {
                    triangulo.tipo("Equilátero");
                    triangulo.recto();
                }
                if ((triangulo.lado1 == triangulo.lado2 && triangulo.lado1 != triangulo.lado3) || (triangulo.lado1 == triangulo.lado3 && triangulo.lado1 != triangulo.lado2) || (triangulo.lado2 == triangulo.lado3 && triangulo.lado2 != triangulo.lado1))
                {
                    triangulo.tipo("Isósceles");
                    triangulo.recto();
                }
                if (triangulo.lado1 != triangulo.lado2 && triangulo.lado2 != triangulo.lado3)
                {
                    triangulo.tipo("Escaleno");
                    triangulo.recto();
                }
                total += triangulo.lado1 + triangulo.lado2 + triangulo.lado3;
            }
            triangulo.super(total);
        }
        public class triangulo
        {
            public triangulo() { }

            //Atributos
            public double lado1;
            public double lado2;
            public double lado3;

            //Métodos
            public void tipo(string tipo)
            {
                Console.WriteLine("El Triángulo es de tipo {0}", tipo);
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
            public void super(double total)
            {
                Console.WriteLine("La superficie del triángulo es de: " + total);
            }
        }
    }
}
