// Enunciado
//Modifique el ejercicio 2 para poder ingresar n docentes mostrando en cada momento los
//datos de cada uno, nombre, sueldo bruto, aporte de jubilación, aporte de obra social y sueldo
//neto. Al finalizar muestre:
//. la suma total de sueldos brutos
//. la suma total de aporte de jubilación
//. la suma total de aporte de obra social
//. la suma total de sueldos neto

// Variable
double jubilacion = 0;
double social = 0;
int hora = 0;
double bruto = 0;
double neto = 0;
int limite = 0;
string nombre;
double sumbruto = 0;
double sumjub = 0;
double sumobra = 0;
double sumneto = 0;

// Código
Console.WriteLine("Indique con cuantos profesores quiere calcular: ");
limite = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < limite; i++)
{
    Console.WriteLine("Escriba su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Escriba cuantas horas trabajó: ");
    hora = Convert.ToInt32(Console.ReadLine());
    bruto = 4200 * hora;
    jubilacion = 0.11 * bruto;
    social = 0.04 * bruto;
    neto = bruto - (jubilacion - social);
    Console.WriteLine("El sueldo bruto es de: " + bruto);
    Console.WriteLine("El sueldo aportado a la jubilacion es de: " + jubilacion);
    Console.WriteLine("El sueldo aportado a la obra social es de: " + social);
    Console.WriteLine("El sueldo neto es de: " + neto);
    sumbruto += bruto;
    sumjub += jubilacion;
    sumobra += social;
    sumneto += neto;
}

Console.WriteLine("El sueldo bruto de todos los profesores juntos es de: " + sumbruto);
Console.WriteLine("El sueldo aportado a la jubilacion de todos los profesores juntos es de: " + sumjub);
Console.WriteLine("El sueldo aportado a la obra social de todos los profesores juntos es de: " + sumobra);
Console.WriteLine("El sueldo neto de todos los profesores juntos es de: " + sumneto);