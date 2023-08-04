using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int nume1, int nume2)
        {
            return nume1 + nume2;
        }

        public int Subtrair(int nume1, int nume2)
        {
            return nume1 - nume2;
        }

        public int Multiplicar(int nume1, int nume2)
        {
            return nume1 * nume2;
        }

        public int Dividir(int nume1, int nume2)
        {
            return nume1 / nume2;
        }
    }
}
