// Construtor por herança
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa     // : Professor para herdar da classe Pessoa
    {
        public Professor(string nome) : base(nome)  // Esse nome vai ser passado para a classe pessoa. base passa para a classe pai, pessoa.
        {
                        
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}

