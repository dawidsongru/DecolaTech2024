﻿using ExemploExplorando.Models;             // Importar o namespace que está dentro de Models
using System.Globalization;

// Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();  // Criar um tipo Dictionary. Precisa passar 2 tipos
                                                                        // 1º elemento é a chave. 2º elemento é o valor.
                                                                        // 1º elemento tem que ser único, não pode existir outro, senão irá causar uma exceção.
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)                // Percorrer o dicionário
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// estados.Add("BA", "Bahia");              // Se tentar adicionar novamente, vai gerar um erro, uma exceção.

Console.WriteLine("----------------------");

// Remover BA    
estados.Remove("BA");                           // Removendo “BA”, passando a chave.

// Alterando o valor
estados["SP"] = "São Paulo - valor alterado";   // Alterando "SP", passando a chave e o novo conteúdo 

foreach(var item in estados)                    // Percorrer o dicionário
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("----------------------");


// Velificando se um elemento existe no Dictionary
string chave = "BA";                            // criar uma string chave e procurar por "BA"
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))                // ContainsKey: Utilizar esse método para verificar se uma chave já foi adicionada ou não.
{
    Console.WriteLine($"Valor existente: {chave}");
}

else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}\n");
}


// Como obter o valor "Minas Gerais"
Console.WriteLine(estados["MG"]);           // Obtendo o valor "Minas Gerais"

Console.WriteLine("");









// // Pilha
// Stack<int> pilha = new Stack<int>();        // Criar uma pilha. Stack<int> int é o tipo, inteiro.

// pilha.Push(4);                              // Adicionar elementos no topo da pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");   // Remover elementos da pilha

// pilha.Push(20);                             // Adicionar mais um elementos no topo da pilha

// foreach(int item in pilha)                  // Listar novamente a fila
// {
//     Console.WriteLine(item);
// }





// // Fila
// Queue<int> fila = new Queue<int>();         // Criar uma fila. Queue<int> int é o tipo, inteiro.

// fila.Enqueue(2);                            // Adicionar elementos no final da fila
// fila.Enqueue(4); 
// fila.Enqueue(6); 
// fila.Enqueue(8); 

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");   // Remover elementos na fila
// fila.Enqueue(10);                           // Adicionar novo elementos no final da fila

// foreach(int item in fila)                   // Listar novamente a fila
// {
//     Console.WriteLine(item);
// }










//new ExemploExcecao().Metodo1();









// try // tente
// {
//     // Realizando a leitura de um arquivo
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");   // Array de strings. File é uma classe para ler arquivos. ReadAllLines ler todas as linhas.

//     foreach(string linha in linhas)     //  iterar sobre cada linha no array de strings
//     {
//         Console.WriteLine(linha);
//     }
// }
//  catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
//  catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. " + ex.Message);
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui"); 
// }







// // Validando o retorno do TryParse
// // string dataString = "2022-04-170 18:00";                     // Data errada
// string dataString = "2022-04-17 18:00";                         // Data correta

// bool sucesso = DateTime.TryParseExact(dataString,               // Tentar converter a String em uma data válida. dataString é a data que você quer trabalhar.
//                        "yyyy-MM-dd HH:mm",                      // Formato    
//                        CultureInfo.InvariantCulture,            // Independe da Cultura
//                        DateTimeStyles.None, out DateTime data); // Se conseguir converter ou não, joga numa variável data.

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data vállida");
// }





// // DateTime com TryParse
// string dataString = "2022-04-17 18:00";                         // Data em formato de String

// DateTime.TryParseExact(dataString,                              // Tentar converter a String em uma data válida. dataString é a data que você quer trabalhar.
//                        "yyyy-MM-dd HH:mm",                      // Formato    
//                        CultureInfo.InvariantCulture,            // Independe da Cultura
//                        DateTimeStyles.None, out DateTime data); // Se conseguir converter ou não, joga numa variável data.

// Console.WriteLine(data);









// Formatando data e hora
// DateTime data = DateTime.Now;               // Now significa agora, data e hora atual.

// Console.WriteLine(data.ToShortDateString());    // Só data.
// Console.WriteLine(data.ToShortTimeString());    // Só hora.





// // DateTime
// DateTime data = DateTime.Now;               // Now significa agora, data e hora atual.

// Console.WriteLine(data);                                // Data e hora atual.
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));   // MM mês. mm min. HH formato de 24hs.
// Console.WriteLine(data.ToString("dd/MM/yy hh:mm"));     // MM mês. mm min. hh formato de 12hs.
// Console.WriteLine(data.ToString("dd/M/yyyy"));          // M mês ocultando o 0.
// Console.WriteLine(data.ToString("dd-MM-yyyy"));         // Data separada por -.
// Console.WriteLine(data.ToString("yyyy-MM-dd"));         // Ano-Mês-Dia.





// // Lembrando que essa cultura vai funcionar para todo o sistema
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // No começo do código inserir a linha e informar a cultura do sistema entre parênteses.

// decimal valorMonetario = 1582.40M;          // Decimal precisa colocar o M no final para ele reconhecer.

// // Console.WriteLine($"{valorMonetario:C}");   // interpolação de String e :, formatar com uma determinada formatação. C significa currency = moeda. 
// Console.WriteLine(valorMonetario.ToString("N2"));    // formatar sem usar a Interpolação de String. C = currency. N = número. 2 = duas casas decimais.

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));













// // Concatenar Strings

// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


// // Concatenar Inteiros

// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);



// // Implementando o método listar alunos
// Pessoa p1 = new Pessoa(nome: "Dawidson", sobrenome: "Pereira");               // Instanciada uma classe Pessoa. Variável p1 do tipoo Pessoa.
// // p1.Nome = "Dawidson";
// // p1.Sobrenome = "Pereira";

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");          // Instanciada uma classe Pessoa. Variável p2 do tipoo Pessoa.
// // p2.Nome = "Eduardo";
// // p2.Sobrenome = "Neves Quairoz";

// Curso cursoDeIngles = new Curso();      // Instanciar uma classe chamada Curso e chamar de Inglês
// cursoDeIngles.Nome = "Ingles";          // Nome é uma propriedade, tem Get e Set.
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();





// Pessoa p1 = new Pessoa();            // Instanciada uma classe Pessoa. Variável p1 do tipoo Pessoa.
// p1.Nome = "Dawidson";
// p1.Sobrenome = "Pereira";
// p1.Idade = 20;
// p1.Apresentar();