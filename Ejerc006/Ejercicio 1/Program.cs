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
            triangulo triangulo = new triangulo();
            Console.WriteLine("Defina el lado 1");
            triangulo.lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Defina el lado 2");
            triangulo.lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Defina el lado 3");
            triangulo.lado3 = Convert.ToInt32(Console.ReadLine());
            if (triangulo.lado1 == triangulo.lado2 && triangulo.lado2 == triangulo.lado3)
            {
                triangulo.tipo("Equilátero");
            }
            if ((triangulo.lado1 == triangulo.lado2 && triangulo.lado1 != triangulo.lado3)|| (triangulo.lado1 == triangulo.lado3 && triangulo.lado1 != triangulo.lado2) || (triangulo.lado2 == triangulo.lado3 && triangulo.lado2 != triangulo.lado1))
            {
                triangulo.tipo("Isósceles");
            }
            if (triangulo.lado1 != triangulo.lado2 && triangulo.lado2 != triangulo.lado3)
            {
                triangulo.tipo("Escaleno");
            }
            triangulo.recto();
            triangulo.super();
        }
        public class triangulo
        {
            public triangulo(){}

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
                    if (lado3*lado3 + lado2*lado2 == lado1*lado1)
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
            public void super()
            {
                Console.WriteLine("La superficie del triángulo es de: " + (lado1 + lado2 + lado3));
            }
        }
    }
}
