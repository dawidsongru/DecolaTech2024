﻿using ExemploFundamentos.Models;

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
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));    // Data atual mais 5 dias, e horário sem milisegundos







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