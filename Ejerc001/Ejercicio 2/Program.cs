//Variables
int num = 0;
int den = 0;
float resultado = 0;
//Código
Console.WriteLine("Coloque el numerador");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Coloque el denominador (recuerde que no puede ser 0)");
den = Convert.ToInt32(Console.ReadLine());
while (den == 0)
{
    Console.WriteLine("El numerador no puede ser 0, escriba otro por favor");
    den = Convert.ToInt32(Console.ReadLine());
}
resultado = num / den;
Console.WriteLine("El resultado de la operación es: " + resultado);