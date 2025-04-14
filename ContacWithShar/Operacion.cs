using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContacWithShar
{
    public class Operacion
    {
        public int A { get; set; }
        public int B { get; set; }

        public Operacion(int a, int b)
        {
            A = a;
            B = b;
        }

        public int Sumar()
        {
            return A + B;
        }
        public int Restar()
        {
            return A - B;
        }
        public int Multiplicar()
        {
            return A * B;
        }
        public int Dividir()
        {
            if (B == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
            return A / B;
        }
    }
}