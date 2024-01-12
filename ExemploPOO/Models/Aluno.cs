// Construtor por herança
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa     // : Aluno para herdar da classe Pessoa
    {
        public Aluno(string nome) : base(nome)  // Esse nome vai ser passado para a classe pessoa. base passa para a classe pai, pessoa.
        {
            
        }

        public double Nota { get; set; }

        public override void Apresentar()   // Sobrescrever o método Apresentar
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}
