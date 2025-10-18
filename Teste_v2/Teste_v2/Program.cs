// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Teste_v2;

class Program
{
    static void Main(string[]args)
    {
        //exercicio 1
        Pessoa1 p = new Pessoa1();

        Console.WriteLine("Entre com os dados do produto:");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade no estoque: ");
        p.Quantidade = Convert.ToInt32(Console.ReadLine());

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

        //fim exercicio 1

        //Exercicio 2
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retângulo:");
        r.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.WriteLine($"AREA: {r}");

        //fim exercicio 2

        //Exercicio 3

        Exercicio_2 f = new Exercicio_2();

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.Write("Salário Bruto: ");
        f.SalarioBruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        f.Imposto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.WriteLine($"Funcionário: {f}");

        Console.WriteLine();

        Console.Write("Digite a porcentage para aumentar o salário: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        f.AumentarSalario(porcentagem);

        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {f}");

        //fim exercicio 3

        //Exercicio 4
        Exercicio_3 q = new Exercicio_3();

        Console.Write("Nome do aluno: ");
        q.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno:");
        q.Nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        q.Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        q.Nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.WriteLine(q);
        //fim exercicio 4
    }
}
