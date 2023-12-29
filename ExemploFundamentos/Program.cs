using ExemploFundamentos.Models;

// double a = 4 / 2 + 2;       // O C# obedece a mesma ordem das operações matemáticas
                            // 1º Parênteses, 2º Expoente, 3º Divisão e Multiplicação e 4º Adição e Subtração

double a = 4 / (2 + 2);

Console.WriteLine(a);














// int a = 5;            // funciona porque int cabe em double
// double b = a;

// int a = 5;            // funciona porque int cabe em long
// long b = a;

// long a = 5;           // não funciona, porque long não cabe em int
// int b = a;

// long a = 5;           // agora funciona, porque fez a conversão.
// int b = Convert.ToInt32(a);

// long a = long.MaxValue;     // não funciona, porque MaxValue é o valor máximo que o Long representa e o Long não cabe dentro de Int.
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;     // funciona, porque MaxValue é o valor máximo que o Int representa e o Int cabe dentro de Long.
// long b = a;

// Console.WriteLine(b);



// string a = 5;                      // dá erro
// string a = "5";                    // funciona

// int inteiro = 5;                      // funciona
// string a = inteiro.ToString();

// Console.WriteLine(a);




// Cast ou Casting: é o processo de conversão de um tipo para outro, neste caso, String para Inteiro.
// int a = Convert.ToInt32(null);        // ToInt32 é uma variável do tipo inteiro de 32 bits, que representa um número de aproximadamente 2 bilhões
// int a = int.Parse(null);

// Console.WriteLine(a);



// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;   // 30 + 5

// c += 5;      // 30 + 5
// c -= 5;       // 30 - 5
// c *= 5;         // 30 * 5


// Console.WriteLine(c);



// Data e hora atual
// DateTime dataAtual = DateTime.Now;      // Data e hora atual
// Console.WriteLine(dataAtual);

// Data atual +5 dias e Hora atual
// DateTime dataAtual = DateTime.Now.AddDays(5);   // Data atual +5 dias e Hora atual
// Console.WriteLine(dataAtual);

// Data atual mais 5 dias, sem horário
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));    // Data atual mais 5 dias, sem horário. O mês é sempre com MM maiúsculo.

// Data atual mais 5 dias, e horário sem milisegundos
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));    // Data atual mais 5 dias, e horário sem milisegundos







// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Dawidson";
// pessoa1.Idade = 45;
// pessoa1.Apresentar();