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
            Alunos.Add(aluno);                      // Adicionar aluno
        }

        public int ObterQuantidadeDeAlunosMatriculados()   // inteiro para contar quantos alunos eu tenho matriculados
        {
            int quantidade = Alunos.Count; // criar uma variável do tipo inteiro. Count retorna o número de elementos dentro de uma lista de inteiros.
            return quantidade;             // return significa que você chegou ao final do seu Método e ele vai te retornar alguma coisa.
        }

        // public void RemoverAluno(Pessoa aluno)   // void significa vazio, não precisa de retorno
        public bool RemoverAluno(Pessoa aluno)      // qualquer método for diferente de void, precisa de retorno
        {
            return Alunos.Remove(aluno);                   // Adicionar aluno
            // return true;                         // posso remover o return true; e colocar apenas o return na linha acima.
        }
    }
}