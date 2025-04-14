using ConditionalsAndLoops;

Console.WriteLine("Condicionales y bucles");

// Condicionales
Condicional condicionales = new Condicional();
condicionales.Condicionales(5);
condicionales.Condicionales(-3);
condicionales.Condicionales(0);
string name = condicionales.Condicionales("Juan");
Console.WriteLine("Name: "+name);
string vacio = condicionales.Condicionales("");
Console.WriteLine("Vacio: "+ vacio);
condicionales.Condicionales(5, 10);
condicionales.Condicionales(10, 5);
condicionales.Condicionales(5, 5);
List<string> result = condicionales.Condicionales(new List<string> { "Juan", "", "Pedro", "Maria" });
Console.WriteLine("Total: "+result.Count.ToString());
Console.WriteLine(result[1]);
Console.WriteLine(string.Join(", ", result));

int contador = condicionales.Condicionales("hola","hola hola, que vas hacer hoy?");
Console.WriteLine("Contador: "+contador);
condicionales.login("Juan", "123");
condicionales.DiasDeLaSemana(1);
condicionales.DiasDeLaSemana(8);
condicionales.MesesDelAño(1);
condicionales.MesesDelAño(13);