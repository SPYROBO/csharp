//Variables
int cant = 0;
int num = 0;
int contador = 0;
int suma = 0;
//Código
Console.WriteLine("Coloque la cantidad de números: ");
cant = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= cant; i++)
{
    Console.WriteLine("Coloque el número: ");
    num = Convert.ToInt32(Console.ReadLine());
    suma += num;
    contador++;
}
Console.WriteLine("La cantidad de números ingresados es de: " + cant);
Console.WriteLine("El promedio es de: " + suma / cant);