// Classe selada na Prática
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public selead class Professor : Pessoa     // : Professor para herdar da classe Pessoa. Colocar a palavra selead (selado)
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}





// // Construtor por herança
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemploPOO.Models
// {
//     public class Professor : Pessoa     // : Professor para herdar da classe Pessoa. Colocar a palavra selead (selado)
//     {
//         public decimal Salario { get; set; }

//         public override void Apresentar()
//         {
//             Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
//         }
//     }
// }
