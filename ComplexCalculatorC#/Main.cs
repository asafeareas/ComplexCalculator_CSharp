using System;
using System.Globalization;

namespace ComplexCalculator {
    public class ComplexCalculator {
        
        static void Main(string[] args) {
            System.Console.WriteLine("Calculadora:");
            System.Console.WriteLine("Escolha a operação:");
            System.Console.WriteLine("1 - Equação de segundo grau");
            // Você pode adicionar outras opções de operação aqui no futuro

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) {
                ResolverEquacaoSegundoGrau();
            }
            else {
                System.Console.WriteLine("FIM");
            }
            // Você pode adicionar outros `if` ou `switch` para outras operações
        }

        static void ResolverEquacaoSegundoGrau() {
            System.Console.Write("Escreva o valor de a: ");
            float a = float.Parse(Console.ReadLine());

            System.Console.Write("Escreva o valor de b: ");
            float b = float.Parse(Console.ReadLine());

            System.Console.Write("Escreva o valor de c: ");
            float c = float.Parse(Console.ReadLine());

            float delta = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x = -b / (2 * a);

            if (delta < 0) {
                System.Console.WriteLine("A equação não possui raízes reais.");
            }
            else if (delta == 0) {
                System.Console.WriteLine($"A equação possui uma raiz real: {x}");
            }
            else {
                System.Console.WriteLine("A equação possui duas raízes reais.");
                System.Console.WriteLine($"Raiz 1: {x1}, Raiz 2: {x2}");
            }
        }
    }
}