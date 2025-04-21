using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    public class Bucle
    {
        // Bucles 
        // Bucle while

        public void ContadorAscendente(int n){
            while (n <= 50)
            {
                Console.WriteLine("Numero: "+ n);
                n++ ;
            }
        }

        public void SumaDeNumeros(int d){
            int suma = 0;
            int cont = 1;
            while (cont <= d)
            {
                suma += cont;
                Console.WriteLine("Sumando: "+ cont);
                cont++;
            }
                Console.WriteLine("Suma Total: "+suma);
                
        }

        public void ValidacionDeEntrada(int s){
            while (s > 0){
                Console.WriteLine("El numero es positivo¡¡¡");
                return;
            }
            Console.WriteLine("El numero es cero o negativo");
        }

        public void ValidarPassword(string pass){
                while (pass.Length > 0 && pass.Contains("1234")){
                    Console.WriteLine("Bienvenido al sistema...");
                    return;
                }
                ValidarPassword(pass);
        } 
    }
}