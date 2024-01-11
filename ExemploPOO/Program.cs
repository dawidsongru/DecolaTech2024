// Objeto é a concretização do que você está representando (criando)
using ExemploPOO.Models;        // A nossa classe Pessoa está dentro da pasta ExemploPOO.Models

Pessoa p1 = new Pessoa();       // Instanciar uma pessoa. Pessoa = new Pessoa, estou criando um objeto do tipo Pessoa. p1 já é o objeto da classe pessoa.

p1.Nome = "Dawidson";           // Passar um nome pra ela
p1.Idade = 45;                  // Passar uma idade pra ela

p1.Apresentar();                // Fazer ela se Apresentar
