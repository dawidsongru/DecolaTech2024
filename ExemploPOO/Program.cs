using ExemploPOO.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);        // instanciar uma conta corrente. Número da conta 123 e valor inicial 1.000

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();









// // Objeto é a concretização do que você está representando (criando)
// using ExemploPOO.Models;        // A nossa classe Pessoa está dentro da pasta ExemploPOO.Models

// Pessoa p1 = new Pessoa();       // Instanciar uma pessoa. Pessoa = new Pessoa, estou criando um objeto do tipo Pessoa. p1 já é o objeto da classe pessoa.

// p1.Nome = "Dawidson";           // Passar um nome pra ela
// p1.Idade = 45;                  // Passar uma idade pra ela

// p1.Apresentar();                // Fazer ela se Apresentar
