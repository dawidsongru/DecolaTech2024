// Método padrão na interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        // public int Dividir(int num1, int num2)       // Se apagar o método calculadora, o programa funciona normalmente, sem erro. 
        // {
        //     return num1 / num2;
        // }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}











// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemploFundamentos.Models
// {
//     public class Calculadora
//     {
//         public void Somar(int x, int y)
//         {
//             Console.WriteLine($"{x} + {y} = {x + y}]");
//         }

//         public void Subtrair(int x, int y)
//         {
//             Console.WriteLine($"{x} - {y} = {x - y}]");
//         }

//         public void Multiplicar(int x, int y)
//         {
//             Console.WriteLine($"{x} * {y} = {x * y}]");
//         }

//         public void Dividir(int x, int y)
//         {
//             Console.WriteLine($"{x} / {y} = {x / y}]");
//         }
//     }
// }

