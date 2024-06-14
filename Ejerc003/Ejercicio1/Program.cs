// Variables
int numero1 = 0;
int numero2 = 0;
int suma = 0;
int resta = 0;
int mult = 0;
float div = 0;
// Código
Console.WriteLine("Coloque el número 1");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Coloque el número 2 (Recuerde que no puede ser 0 si es que quiere dividir)");
numero2 = Convert.ToInt32(Console.ReadLine());
suma = numero1 + numero2;
resta = numero1 - numero2;
mult = numero1 * numero2;
Console.WriteLine("El resultado entre estos dos números es: {0}" , suma);
Console.WriteLine("La diferencia entre estos dos números es: {0}" , resta);
Console.WriteLine("El producto entre estos dos números es: {0}", mult);
if (numero2 != 0)
{
    div = numero1 / numero2;
    Console.WriteLine("El cociente entre estos dos números es: {0}", div);
}
else
{
    Console.WriteLine("No se puede hacer la division");
}