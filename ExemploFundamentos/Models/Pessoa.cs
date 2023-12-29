using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }   // você pode declarar uma propriedade como anulável usando a sintaxe Tipo?, indicando que ela pode aceitar o valor null. Ao marcar a propriedade 'Nome' como anulável, você informa ao compilador que ela pode ter um valor null, evitando o aviso CS8618.
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é " +
            $"{Nome}, e tenho {Idade} anos \n");

            Console.WriteLine($"Olá, meu nome é {Nome} \ne tenho {Idade} anos \n");
        }
    }
}