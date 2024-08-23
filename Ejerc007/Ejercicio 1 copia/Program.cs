using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_copia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso = new int[] {1,2,3,4,5};
            int pos_peso = 0;
            int[] promedio;
            int estacion1 = 0;
            int estacion2 = 0;
            int total = 0;
            int c = 0;
            string i = "si";
            informacion info = new informacion();
            while (i == "SI" || i == "Si" || i == "si")
            {
                //Console.WriteLine("Indique número de pasaje");
                //info.num_pasaje = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Indique el nombre del pasajero");
                //info.nombre = Console.ReadLine();
                //Console.WriteLine("Indique la fecha del viaje");
                //info.fecha = Console.ReadLine();
                //Console.WriteLine("Indique con cuantas maletas viaja");
                int cant = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j <= cant; j++)
                {
                    Console.WriteLine("Indique el peso de la maleta {0}", j);
                    int kilos = Convert.ToInt32(Console.ReadLine());
                    info.peso_valijas += kilos;
                    total += info.peso_valijas;
                    peso[pos_peso] = kilos;
                    pos_peso++;
                }
                promedio = new int[(info.peso_valijas / cant)];
                info.peso_valijas = 0;
                Console.WriteLine("Indique si viaja a la Estación 1 o 2 pero solo con el número");
                info.destino = Console.ReadLine();
                if (info.destino == "1")
                {
                    estacion1++;
                }
                if (info.destino == "2")
                {
                    estacion2++;
                }
                Console.WriteLine("¿Añade otro usuario? diga si en caso que asi sea");
                i = Console.ReadLine();
                c++;
            }
            Console.WriteLine(peso.ToString());
            //info.mostrarDatos(c, estacion1, estacion2, total, ,  ); 
        }
        public class informacion
        {
            //Constructor
            public informacion()
            {

            }
            //Atributos
            public int num_pasaje;
            public string nombre;
            public string fecha;
            public int peso_valijas;
            public string destino;

            //Métodos
            public void mostrarDatos(int c, int e1, int e2, int t, int[] peso)
            {

            }
        }
    }
}