using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nInforme uma expressão matemática (ou 'sair'): ");
                string operacao = Console.ReadLine();

                if (operacao.ToLower() == "sair")
                    break;

                char operador = ' ';

                foreach (char c in operacao)
                {
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        operador = c;
                        break;
                    }
                }

                string[] partes = operacao.Split(operador);

                double num1 = Convert.ToDouble(partes[0]);
                double num2 = Convert.ToDouble(partes[1]);

                double resultado = 0;

                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;

                    case '-':
                        resultado = num1 - num2;
                        break;

                    case '*':
                        resultado = num1 * num2;
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: divisão por zero.");
                            continue;
                        }
                        resultado = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("Calculadora encerrada.");
            Console.ReadKey();
        }
    }
}
