using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        
        public void Potencia(int x, int y)
        {   
            double pot = Math.Pow(x, y);                // Pow = Power = Potência
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)                 // Sin = Sine = Seno
        {                                     // primeiro divisão Math.PI / 180, depois multiplicação angulo * Math.PI
            double radiano = angulo * Math.PI / 180;    // Seno é calculado em Radianos. Para calcular Radianos, pegamos PI (3,141) / 180. Convertido.
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");   // Math.Round arredonda o número com a quantidade de dígitos desejada, 4.
        }

        public void Coseno(double angulo)                 // Cos = Coseno
        {
            double radiano = angulo * Math.PI / 180;    
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");    // Math.Round arredonda o número com a quantidade de dígitos desejada, 4.
        }
        
        public void Tangente(double angulo)                 // Tan = Tangente
        {
            double radiano = angulo * Math.PI / 180;    
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");    // Math.Round arredonda o número com a quantidade de dígitos desejada, 4.
        }
    }
}