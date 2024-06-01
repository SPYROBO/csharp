// Variables
int edad = 0;
int suma = 0;
int contador = 0;
// Código
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Coloque la edad de el niño número " + i);
    edad = Convert.ToInt32(Console.ReadLine());
    if (edad % 2 == 0)
    {
        Console.WriteLine("Es par");
    }
    else
    {
        Console.WriteLine("No es par");
    }
    suma += edad;
    contador++;
}
Console.WriteLine("El promedio de las edades es de: " + suma / contador);
