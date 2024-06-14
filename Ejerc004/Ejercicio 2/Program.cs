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


            //Instanciación de la clase
            nariz objNariz = new nariz();
            nariz objNariz2 = new nariz();

            //Acción obj 1
            objNariz.color = "mestizo";
            objNariz.forma = "puntiaguda";
            objNariz.tamaño = "mediana";
            objNariz.inhalar();
            objNariz.exhalar();

            //Acción obj 2
            objNariz2.color = "moreno";
            objNariz2.forma = "redondeada";
            objNariz2.tamaño = "pequeña";
            objNariz2.inhalar();
            objNariz2.exhalar();
        }

        //Nueva Clase
        public class nariz
        {
            //Constructor 
            public nariz()
            {

            }
            //Atributos
            public string color;
            public string forma;
            public string tamaño;

            //Métodos 
            public void inhalar()
            {
                Console.WriteLine("La nariz de color {0}, de forma {1} y de tamaño {2} inhaló", color, forma, tamaño);
            }
            public void exhalar()
            {
                Console.WriteLine("La nariz de color {0}, de forma {1} y de tamaño {2} exhaló", color, forma, tamaño);
            }
        }

    }
}

