using System;
using System.Globalization;

namespace Ex_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            LerDados(out string numeroConta, out string titularConta, out double saldoConta);

            // Instanciar Conta Bancária
            ContaBancaria contaBancaria = new ContaBancaria(numeroConta, saldoConta, titularConta);
            Console.WriteLine(contaBancaria);
            Console.ReadLine();

            // Depósito
            Deposito(numeroConta, saldoConta, contaBancaria);

            // Saque
            Saque(numeroConta, saldoConta, contaBancaria);

        }

        private static void Saque(string numeroConta, double saldoConta, ContaBancaria contaBancaria)
        {
            Console.WriteLine("Digite o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(numeroConta, saldoConta, valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.ReadLine();
        }

        private static void Deposito(string numeroConta, double saldoConta, ContaBancaria contaBancaria)
        {
            Console.WriteLine("Digite o valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Depositar(numeroConta, saldoConta, valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.ReadLine();
        }

        private static void LerDados(out string numeroConta, out string titularConta, out double saldoConta)
        {
            Console.WriteLine("Digite o número da Conta: ");
            numeroConta = Console.ReadLine();
            Console.WriteLine("Digite o nome do Titular: ");
            titularConta = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?: ");
            string auxDepositoInicial = Console.ReadLine();
            saldoConta = 0.0;
            if (auxDepositoInicial.Equals("s"))
            {
                Console.WriteLine("Digite o valor do depósito inicial: ");
                saldoConta = double.Parse(Console.ReadLine());
            }
        }
    }
}
