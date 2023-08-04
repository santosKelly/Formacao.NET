using POO.Interfaces;
using POO.Models;

//Pessoa p1 = new Pessoa("Billy");
//p1.Nome = "Billy";
//p1.Idade = 12;

//p1.Apresentar();

//ContaCorrente c1 = new ContaCorrente(123, 1000);
//c1.ExibirSaldo();
//c1.Sacar(500);
//c1.ExibirSaldo();

////////********Classe Object*********/////
//Computador computer = new Computador();
//Console.WriteLine(computer.ToString());

///***Interfaces***//
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));