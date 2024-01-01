using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Não queremos que o nome seja vazio.
        private string _nome;                   // criar um campo do tipo privado
        
        public string Nome
        {
            get                                 // Obter valor.
            {
                return _nome.ToUpper();         // Retornar um nome com todas as letras maiúsculas.
            }

            set                                 // Atribuir valor.
            {
                if (value == "")                // se valor for igual a vazio. O value é o argumento que está recebendo o nome.
                {
                    throw new ArgumentException("O nome não pode ser vazio");    // disparar uma exceção
                }

                _nome = value;
            }
        }
 
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}