using ExemploExplorando.Models;         // Importar o namespace que está dentro de Models

// Implementando o método listar alunos
Pessoa p1 = new Pessoa(nome: "Dawidson", sobrenome: "Pereira");               // Instanciada uma classe Pessoa. Variável p1 do tipoo Pessoa.
// p1.Nome = "Dawidson";
// p1.Sobrenome = "Pereira";

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");          // Instanciada uma classe Pessoa. Variável p2 do tipoo Pessoa.
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Quairoz";

Curso cursoDeIngles = new Curso();      // Instanciar uma classe chamada Curso e chamar de Inglês
cursoDeIngles.Nome = "Ingles";          // Nome é uma propriedade, tem Get e Set.
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





// Pessoa p1 = new Pessoa();            // Instanciada uma classe Pessoa. Variável p1 do tipoo Pessoa.
// p1.Nome = "Dawidson";
// p1.Sobrenome = "Pereira";
// p1.Idade = 20;
// p1.Apresentar();