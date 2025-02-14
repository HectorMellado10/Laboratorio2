string nombre;
double Sueldo;
int edad;

Console.WriteLine("Cual es tu nombre? ");
nombre=Console.ReadLine();
Console.WriteLine("Hola " + nombre + ", Que edad tienes?");

bool ConversionExitosa = int.TryParse(Console.ReadLine(), out edad) && edad >= 6 && edad <= 120;
if (ConversionExitosa)
    {
    Console.WriteLine("Tu edad es " + edad);
}
else
{
    Console.WriteLine("Ingresaste algo incorrecto, recuerda que solo puedes ingresar numeros enteros o ingresaste una edad imposible");
}

/*lo de arriba es la declaracion y la ejecucion de variable booleana, usted pidio que fuese verdadero o falso,
entonces aunque no sea literalmente true o false creo que cumple con el enunciado que nos dió*/

Console.WriteLine("Ingresa tu sueldo(PuedesUsarDecimales)");
bool ConversionSueldo = double.TryParse(Console.ReadLine(), out Sueldo);
if (ConversionSueldo)
{
    Console.WriteLine("Tu sueldo es "+ Sueldo);
}
else
{
    Console.WriteLine("Ingresaste algo incorrecto, recuerda que solo puedes ingresar numeros enteros y decimales");
}

/*Empieza aqui el segundo ejercicio*/

Console.WriteLine("Ahora vamos a hacer operaciones matematicas.");
Console.WriteLine("Ingresa un numero");
Double numero1;
while (!double.TryParse(Console.ReadLine(), out numero1)) 
{
    Console.WriteLine("Numero no valido, ingresa un numero");
}
Console.WriteLine("Ingresa un segundo numero");
Double numero2;
while (!double.TryParse(Console.ReadLine(), out numero2))
{ 
    Console.WriteLine("Numero no valido, ingresa un numero");
}

double suma = numero1 + numero2;
double resta = numero1 - numero2;
double multiplicar = numero1 * numero2;
double dividir = numero1 / numero2;

Console.WriteLine("Resultados de las operaciones");
Console.WriteLine($"{numero1} + {numero2} = {suma}");
Console.WriteLine($"{numero1} - {numero2} = {resta}");
Console.WriteLine($"{numero1} * {numero2} = {multiplicar}");
Console.WriteLine($"{numero1} / {numero2} = {dividir}");

/*Empieza aqui el tercer ejercicio*/
Console.WriteLine("Empezaremos a hacer operadores logicas.");
Console.WriteLine($"¿{numero1} es mayor que {numero2}? {numero1}>{numero2}");
Console.WriteLine($"¿{numero1} es menor que {numero2}? {numero1}<{numero2}");
Console.WriteLine($"¿{numero1} es igual que {numero2}? {numero1}=={numero2}");

Console.WriteLine($"¿{numero1} es mayor que 0 Y {numero2} es mayor que 0? {numero1 > 0 && numero2 > 0}");
Console.WriteLine($"¿{numero1} es mayor que 0 O {numero2} es mayor que 0? {numero1 > 0 || numero2 > 0}");
    
/*Aca termina el ejercicio, ya abarque todos los puntos solicitados, solo prosigue el readme para completar la tarea*/
