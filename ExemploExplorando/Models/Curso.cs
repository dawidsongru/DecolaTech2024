using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string nome { get; set; }            // Criado uma Propriedade chamada Nome
        public List<Pessoa> Alunos { get; set; }    // Cliar uma Propriedade Coleção, uma Lista de Pessoas. Lista é uma coleção de um determinado tipo.

        public void AdicionarAluno(Pessoa aluno)    // Criar o Método. Como parâmetro, colocar Pessoa e chamar de aluno.
        {
            Alunos.Add(aluno);
        }
    }
}