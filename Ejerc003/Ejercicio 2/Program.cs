// Enunciado
//Un docente gana $ 4200,00 la hora cátedra y trabaja una determinada cantidad de horas
//catedra por mes. A su sueldo se le descuenta el 11% de jubilación y el 4% de la obra social.
//Calcular y mostrar el sueldo bruto, el total de retenciones y el sueldo neto del docente
//ingresando por teclado tanto el nombre del docente como también la cantidad de horas
//trabajadas.

// Variable
int hora = 0;
double bruto = 0;
double neto = 0;
double retenido = 0;
string nombre = "";

// Código
Console.WriteLine("Escriba su nombre: ");
nombre = Console.ReadLine();
Console.WriteLine("Escriba cuantas horas trabajó: ");
hora = Convert.ToInt32(Console.ReadLine());
bruto = 4200 * hora;
retenido = 0.15 * bruto;
neto = bruto - retenido;
Console.WriteLine("El sueldo bruto es de: " + bruto);
Console.WriteLine("El sueldo retenido es de: " + retenido);
Console.WriteLine("El sueldo neto es de: " +  neto);