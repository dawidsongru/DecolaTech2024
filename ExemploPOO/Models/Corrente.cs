// Classe abstrata na prática
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta       // Criar uma classe Corrente e herdar da classe Conta.
    {
        public override void Creditar(decimal valor)    // Implementado método Creditar. override = sobrepor
        {
            saldo += valor;
        }
    }
}
