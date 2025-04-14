using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    public class Condicional
    {
        public string? Nombre { get; set; }
        public string? contrasena { get; set; }
        // Vamos a practicar en metodos usando condicionales
        // Usando if, else if y else
        // Usando el operador ternario
        public void Condicionales(int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                Console.WriteLine("El número es cero");
            }

            // Usando el operador ternario
            string resultado = numero > 0 ? "El número es positivo" : numero < 0 ? "El número es negativo" : "El número es cero";
            Console.WriteLine(resultado);
        }

        public string Condicionales(string nombre)
        {
            // Usando el operador ternario
            string resultado = string.IsNullOrEmpty(nombre) ? "El nombre está vacío" : "El nombre no está vacío";
            return resultado;
        }

        public void Condicionales(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine("El número 1 es mayor que el número 2");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El número 1 es menor que el número 2");
            }
            else
            {
                Console.WriteLine("Los números son iguales");
            }
        }

        public List<string> Condicionales(List<string> nombres)
        {
            List<string> nombresNoVacios = new List<string>();
            foreach (string nombre in nombres)
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    nombresNoVacios.Add(nombre);
                }
            }
            return nombresNoVacios;
        }

        public int Condicionales(string palabra, string oracion)
        {
            if(!string.IsNullOrEmpty(oracion))
            {
                int contador = 0;
                string[] palabras = oracion.Split(' ', ',', '.', ',', ';', ':', '!', '?', '\n', '\r');
                foreach (string p in palabras)
                {
                    if (p.Equals(palabra, StringComparison.OrdinalIgnoreCase))
                    {
                        contador++;
                    }
                }
                
                return contador;
            }
            else
            {
                Console.WriteLine("La oración está vacía");
                return 0;
            }
        }

        public void login(string nombre, string contrasena)
        {
            if (nombre == "Juan" && contrasena == "1234")
            {
                Console.WriteLine("Bienvenido " + nombre);
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrectos");
            }
        }

        // Usando switch
        public void CondicionalesSwitch(int numero)
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("El número es uno");
                    break;
                case 2:
                    Console.WriteLine("El número es dos");
                    break;
                case 3:
                    Console.WriteLine("El número es tres");
                    break;
                default:
                    Console.WriteLine("El número no es uno, dos o tres");
                    break;
            }
        }

        // Dias de la semana
        public void DiasDeLaSemana(int dia)
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Número de día inválido");
                    break;
            }
        }

        // Meses del año
        public void MesesDelAño(int mes)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Número de mes inválido");
                    break;
            }
        }
        
    }
}