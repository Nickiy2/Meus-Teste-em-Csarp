// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Teste_v3;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 1
        Produto_01 p = new Produto_01("TV", 500.50, 10);

        Console.WriteLine("Entre com os dados do produto:\n");

        Console.Write($"Os dados dos produtos são: {p}");

        Console.WriteLine();

        double total = p.ValorTotalEmEstoque();

        Console.WriteLine($"Dados do Produto: {p}");

        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = Convert.ToInt32(Console.ReadLine());

        p.AdicionarProdutos(qte);

        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p}");

        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = Convert.ToInt32(Console.ReadLine());

        p.RemoverProdutos(qte);

        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p}");

        Console.WriteLine(p.Nome);
        p.Nome = "TV 4K";
        Console.WriteLine(p.Nome);
        //Fim Exercício 1

        //Exercício 2
        string nome;
        double saldo;
        int id;
        char opcao;
        Banco conta;

        Console.WriteLine("Bem vindo ao Banco Santos!");

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\nEntre com os dados da conta\n");
        Console.Write("Entre o número da conta:");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entre o titular da conta:");
        nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)?: ");
        opcao = Convert.ToChar(Console.ReadLine());

        //Logica para criar o objeto com ou sem depósito inicial
        if (opcao == 's' || opcao == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            saldo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Banco(id, nome, saldo);

            Console.WriteLine();
            Console.WriteLine("Os dados da conta:");
            Console.Write($"{conta}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
        else
        {
            conta = new Banco(id, nome);

            Console.WriteLine();
            Console.WriteLine("Os dados da conta:");
            Console.Write($"{conta}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
        //Fim Exercício 2
    }
}
