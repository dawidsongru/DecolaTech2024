// Classe abstrata na prática
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta         // Antes de class, escrever abstract. Essa classe agora é abstrata e não pode ser usada diretamente.
    {                                   // abstract só vai servir para ser herdada. // abstract não tem implementação, é só o código dele. 
        protected decimal saldo;        // outra propriedade. protect é protegido contra alterações externas, com exceção das suas classes filhas.
                                        // protect é um privace mais permissivo. É protegido contra alterações extermas, mas classes filhas podem alterar.
        public abstract void Creditar(decimal valor);   // criar um método chamado creditar, como abstrato, mas não vou colocar uma implementação nele.
                                                        // abstract só vai servir para ser herdada. // abstract não tem implementação, é só o código dele.
        public void ExibirSaldo()       // tem implementação, pois abre e fecha chaves. Creditar não tem implementação, não tem chaves.
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}
