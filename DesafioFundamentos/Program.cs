﻿//
// Sistema de Estacionamento em C#
// Autor: Dawidson Pereira
// Data: 09/01/2024
//
using DesafioFundamentos.Models;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        AnimateWelcomeMessage();

        decimal precoInicial = 0M, precoPorHora = 0M;

        Console.WriteLine("Digite o preço inicial:");
        while (!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial < 0)
        {
            Console.WriteLine("Digite um valor válido para precoInicial (maior ou igual a zero):");
        }

        Console.WriteLine("Agora digite o preço por hora:");
        while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)
        {
            Console.WriteLine("Digite um valor válido para precoPorHora (maior ou igual a zero):");
        }

        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine($"\n{"Smart Parking - Sistema de Estacionamento Inteligente".PadRight(70)} Data: {DateTime.Now.ToShortDateString()} | Hora: {DateTime.Now.ToString("HH:mm:ss")}\n");
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculo();
                    break;

                case "2":
                    es.RemoverVeiculo();
                    break;

                case "3":
                    es.ListarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (exibirMenu)
            {
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
        }

        Console.WriteLine("O programa se encerrou");
    }

    static void AnimateWelcomeMessage()
    {
        string mensagem = "Bem-vindo ao Smart Parking - Sistema de Estacionamento Inteligente\nDesejamos a todos os nossos clientes e familiares um excelente ano de 2024, repleto de paz e felicidades.";
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;

        for (int i = 0; i < mensagem.Length; i++)
        {
            Console.Write(mensagem.Substring(0, i + 1));
            Thread.Sleep(50);
            Console.Clear();
        }
        Console.WriteLine(mensagem);
        Thread.Sleep(3000);
        Console.Clear();

        Console.ResetColor();
        Console.WriteLine($"\n{"Smart Parking - Sistema de Estacionamento Inteligente".PadRight(70)} Data: {DateTime.Now.ToShortDateString()} | Hora: {DateTime.Now.ToString("HH:mm:ss")}\n");
    }
}