using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Informe o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Informe o titular da conta: ");
            string nometitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)? ");
            char validardeposito = char.Parse(Console.ReadLine());

            double depositoinicial = 0;

            if (validardeposito == 'S' || validardeposito == 's')
            {
                Console.Write("Informe o valor do depósito inicial: ");
                depositoinicial = double.Parse(Console.ReadLine());
            }
            else if (validardeposito == 'N' || validardeposito == 'n') 
            {
                Console.WriteLine();                
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                return;
            }

            DadosBancarios conta = new DadosBancarios(numeroconta, nometitular, depositoinicial);
            
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine($"{conta}");

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine($"{conta}");

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            
            if (saque == 0)
            {
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine($"{conta}");
            }
            else
            {
                conta.Saque(saque);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine($"{conta}");
            }
        }
    }
}