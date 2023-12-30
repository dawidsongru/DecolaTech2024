using ExemploFundamentos.Models;


Calculadora calc = new Calculadora();    // Instanciar uma classe. Criar uma varável do tipo calculadora.

// calc.Somar(10, 30);                      // a vírcula delimita cada parâmetro. Ex: (10, 30)
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
calc.Potencia(3, 3);








// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)                // se não choveu e não está tarde
// {
//     Console.WriteLine("Vou pedalar");   
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");   
// }




// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }





// bool ehMaiorDeIdade = true;                             // Se uma dessas duas condições for verdadeira, cai no if
// bool possuiAutorizacaoDoResponsavel = false;            
//                                                         // || Operador OU
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)   // o if sempre vai verificar se a condição é verdadeira
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else                                                    // se for falso, sempre cai no else
// {
//     Console.WriteLine("Entrada não liberada!");
// }






// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine() ?? "";

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }





// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine() ?? "";        // Permite que o terminal espere por algum comando e pressione enter

// if (letra == "a" ||     // || Sinal de OU
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }



// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine() ?? "";         // Permite que o terminal espere por algum comando e pressione enter

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }

// else
// {
//     Console.WriteLine("Não é uma vogal");
// }






// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;       // = Operador de atribuição, quando queremos atribuir um valor para uma variável.
// bool possivelVenda = quantidadeCompra > 0 &&   quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)  // ==   Comparação. Compara se um valor é igual a outro, por exemplo.
// {
//     Console.WriteLine("Venda inválida.");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }







// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;   // variável booleana que vai representar true ou false

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");  // Retorna True ou False

// if (possivelVenda)      // if só valida condições.
// {
//     Console.WriteLine("Venda realizada.");      // Condição verdadeira, exibe essa mensagem
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");         // Condição false, não exibe essa mensagem
// }













// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;   // variável booleana que vai representar true ou false

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");  // Retorna True ou False

// if (possivelVenda)      // if só valida condições.
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }





// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;


// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }





// Convertendo de maneira segura


// string a = "15-";           // quando encontrar um erro 15-, o TryParse não interrompe a execução e continua o restante do código.

// int b = 0;
                    // também posso colocar o tipo da variável na mesma linha do TryParse 
// int.TryParse(a, out int b);     // O TryParse vai tentar converter o "a", se não conseguir, o valor de saída será o "b" e continuará a execução do restante do código.


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");















// double a = 4 / 2 + 2;       // O C# obedece a mesma ordem das operações matemáticas
                               // 1º Parênteses, 2º Expoente, 3º Divisão e Multiplicação e 4º Adição e Subtração

// double a = 4 / (2 + 2);

// Console.WriteLine(a);






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