
using ContacWithShar;

Console.WriteLine("Vamos a sumar dos números");
Console.WriteLine("Introduce el primer número");
// int num1 = int.Parse(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el segundo número");
// int num2 = int.Parse(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Operacion operacion = new Operacion(num1, num2);
Console.WriteLine("La suma es: " + operacion.Sumar());
Console.WriteLine("La resta es: " + operacion.Restar());
Console.WriteLine("La multiplicación es: " + operacion.Multiplicar());
Console.WriteLine("La división es: " + operacion.Dividir());
Console.WriteLine("¿Quieres realizar otra operación? (s/n)");
string? respuesta = Console.ReadLine();
while (respuesta?.ToLower() == "s")
{
    Console.WriteLine("Introduce el primer número");
    // num1 = int.Parse(Console.ReadLine());
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce el segundo número");
    // num2 = int.Parse(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    operacion = new Operacion(num1, num2);
    Console.WriteLine("La suma es: " + operacion.Sumar());
    Console.WriteLine("La resta es: " + operacion.Restar());
    Console.WriteLine("La multiplicación es: " + operacion.Multiplicar());
    Console.WriteLine("La división es: " + operacion.Dividir());
    Console.WriteLine("¿Quieres realizar otra operación? (s/n)");
    respuesta = Console.ReadLine();
}
