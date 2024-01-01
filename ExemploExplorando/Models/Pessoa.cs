using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Não queremos que o nome seja vazio.
        private string _nome;               // criar um campo _nome do tipo privado
        private int _idade;                 // criar um campo _idade do tipo privado
        
        public string Nome
        {

        get => _nome.ToUpper();     // Body Expression: Uma maneira mais resumida no GET e SET para seu código ficar mais legível.
        
        // get
        // {
        //     return _nome.ToUpper();      // Se o seu código tiver só uma linha, é preferível usar o Body Expression.
        // }

            set                             // Atribuir valor.
            {
                if (value == "")            // se valor for igual a vazio. O value é o argumento que está recebendo o nome.
                {
                    throw new ArgumentException("O nome não pode ser vazio");    // disparar uma exceção
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }   // nova propriedade
        // public string NomeCompleto { get; }  // NomeCompleto só vai servir para juntar Nome e Sobrenome. Só precisa de GET.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();  // Body Expression, melhorando o código da linha acima { get; }

        public int Idade
        {
            get => _idade;          // Body Expression: Uma maneira mais resumida no GET e SET para seu código ficar mais legível.
            // get;                 // Se o seu código tiver só uma linha, é preferível usar o Body Expression.
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}"); // NomeCompleto vai concatenar Nome e Sobrenome. Só GET.
        }
    }
}
