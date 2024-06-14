using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables


            //Instanciación de la clase
            nariz objNariz = new nariz();

            //Acción 
            objNariz.color = "mestizo";
            objNariz.forma = "puntiaguda";
            objNariz.tamaño = "mediana";
            objNariz.inhalar();
            objNariz.exhalar();
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
