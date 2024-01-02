using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Refatorar o método de ListarAlunos. Exibir os alunos por ordem numérica. 01 -, 02 -...
namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }            // Criado uma Propriedade chamada Nome
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
            return Alunos.Remove(aluno);            // Remover aluno
            // return true;                         // posso remover o return true; e colocar apenas return na linha acima.
        }

        public void ListarAlunos()                  // criar um método CriarAlunos
        {
        
        
            // // Concatenar Strings
            // Console.WriteLine("\nConcatenar Strings \n");
            // Console.WriteLine($"Alunos do curso de: {Nome} ");
                        
            // for (int count = 0; count < Alunos.Count; count++)      // Alunos.Count para contar. variável i, chamar de count, que será o contador.
            // {
            //     string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;  // Concatenar String. Nº do aluno - Nome completo. Criar uma nova variável com o nome texto
            //     Console.WriteLine(texto);
            // }
            //     Console.WriteLine("\n");



            // Interpolar Strings
            Console.WriteLine("\nInterpolar Strings \n");
            Console.WriteLine($"Alunos do curso de: {Nome} ");      
                        
            for (int count = 0; count < Alunos.Count; count++)      // Alunos.Count para contar. variável i, chamar de count, que será o contador.
            {
                string texto = $"Nº {count} - {Alunos[count].NomeCompleto}";    // Interpolar String. $ antes da string. 
                Console.WriteLine(texto);
            }
                Console.WriteLine("\n");




            // foreach (Pessoa aluno in Alunos)        // fazer um laço 
            // {
            //     Console.WriteLine(aluno.NomeCompleto);                
            // }       
        }
    }
}





// namespace ExemploExplorando.Models
// {
//     public class Curso
//     {
//         public string Nome { get; set; }            // Criado uma Propriedade chamada Nome
//         public List<Pessoa> Alunos { get; set; }    // Cliar uma Propriedade Coleção, uma Lista de Pessoas. Lista é uma coleção de um determinado tipo.

//         public void AdicionarAluno(Pessoa aluno)    // Criar o Método. Como parâmetro, colocar Pessoa e chamar de aluno.
//         {
//             Alunos.Add(aluno);                      // Adicionar aluno
//         }

//         public int ObterQuantidadeDeAlunosMatriculados()   // inteiro para contar quantos alunos eu tenho matriculados
//         {
//             int quantidade = Alunos.Count; // criar uma variável do tipo inteiro. Count retorna o número de elementos dentro de uma lista de inteiros.
//             return quantidade;             // return significa que você chegou ao final do seu Método e ele vai te retornar alguma coisa.
//         }

//         // public void RemoverAluno(Pessoa aluno)   // void significa vazio, não precisa de retorno
//         public bool RemoverAluno(Pessoa aluno)      // qualquer método for diferente de void, precisa de retorno
//         {
//             return Alunos.Remove(aluno);            // Remover aluno
//             // return true;                         // posso remover o return true; e colocar apenas return na linha acima.
//         }

//         public void ListarAlunos()                  // criar um método CriarAlunos
//         {
//             Console.WriteLine($"Alunos do curso de: {Nome} ");
//             foreach (Pessoa aluno in Alunos)        // fazer um laço 
//             {
//                 Console.WriteLine(aluno.NomeCompleto);                
//             }       
//         }
//     }
// }