using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente                  // classe ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)        // criar um construtor com ctor, receber o número da conta e o saldoInicial da conta
        {
            NumeroConta = numeroConta;          // no construtor, NumeroConta = numeroConta que estou recebendo
            saldo = saldoInicial;               // no construtor, saldo = saldo que estou recebendo
        }

        public int NumeroConta { get; set; }    // criar uma propriedade com prop e pressiona tab. Uma propriedade do tipo public, quanquer pessoa ver.

        private decimal saldo;                  // criar um atributo chamado saldo, do tipo privado, bloqueado para alterações externas. Só quem altera o saldo é a classe.

        public void Sacar(decimal valor)        // criar um método publico chamado Sacar. Void = vazio
        {
            if (saldo >= valor)
            {
                saldo -= valor;                 // saldo = saldo - valor
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo diaponível");
            }

        }

        public void ExibirSaldo()                 // criar mais um método
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}");
        }
    }
}