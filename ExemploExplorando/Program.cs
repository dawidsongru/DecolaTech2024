using ExemploExplorando.Models;             // Importar o namespace que está dentro de Models
using System.Globalization;                 // Importar o namespace System.Globalization

// Lembrando que essa cultura vai funcionar para todo o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // No começo do código inserir a linha e informar a cultura do sistema entre parênteses.

decimal valorMonetario = 1582.40M;          // Decimal precisa colocar o M no final para ele reconhecer.

// Console.WriteLine($"{valorMonetario:C}");   // interpolação de String e :, formatar com uma determinada formatação. C significa currency = moeda. 
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));    // formatar sem usar a Interpolação de String.
















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