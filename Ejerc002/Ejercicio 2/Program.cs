// Variables 
int edad = 0;
int suma = 0;
int contador = 0;
int cantidad = 0;
int i = 1;
// Código
Console.WriteLine("Cuantos niños quiere calcular");
cantidad = Convert.ToInt32(Console.ReadLine());
while (i <= cantidad)
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
    i++;
}
Console.WriteLine("El promedio de las edades es de: " + suma / contador);
