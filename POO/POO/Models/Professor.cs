using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    //sealed significa que essa classe é uma instância final de uma herança, não pode ter mais classes filhas.
    public sealed class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            //bse significa que estou recebendo um parâmetro e passando para a classe pai.
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é{Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}
