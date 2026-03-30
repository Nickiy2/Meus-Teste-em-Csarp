// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Numerics;
using Teste_v4;

class Program
{
    static void Main(string[] args)
    {
        //Exercio 1º com vetores

        //Criação do vetor com 10 posições
        Dados[] vect = new Dados[10];
        Console.WriteLine("Bem vindo ao Hotel Magalhões");
        Console.WriteLine("\n");

        //Entrada de dados
        Console.Write("Digite quantas pessoas irão se hospedar: ");
        int quantidadePessoas = Convert.ToInt32(Console.ReadLine());

        //For para preencher o vetor com os dados das pessoas
        for (int i = 1; i <= quantidadePessoas; i++)
        {
            Console.WriteLine($"Aluguel #{i}: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quartos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            vect[quartos] = new Dados(nome, email, quartos);

        }

        //Exibição dos quartos ocupados
        Console.WriteLine();
        Console.WriteLine("Quartos Ocupados: ");
        for (int i = 0; i < 10; i++)
        {
            if (vect[i] != null)
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
        }
        
        
        //Exercio 2º com listas

        //Criação da lista de funcionários
        List<Funcionarios> funcionarios = new List<Funcionarios>();

        //Entrada de dados
        Console.Write("Quantos funcionários serão registrados? ");
        int NumerodeFuncionarios = Convert.ToInt32(Console.ReadLine());

        //Entrada de dados dos funcionários e adição na lista
        for (int i = 1; i <= NumerodeFuncionarios; i++)
        {
            Console.WriteLine($"Funcionário #{i}:");
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionarios.Add(new Funcionarios(nome, id, salario));
            Console.WriteLine();
        }

        //Entrada do Id do funcionário que irá receber o aumento
        Console.Write("Digite o Id do funcionário que irá receber o aumento: ");
        int procurarId = Convert.ToInt32(Console.ReadLine());

        //Procura o funcionário na lista pelo Id e aplica o aumento se encontrado, se o contrário exibe mensagem de erro
        Funcionarios funcionario = funcionarios.Find(x => x.Id == procurarId);
        if (funcionario == null)
        {
            Console.WriteLine("Esse funcionário não existe!");
        }
        else
        {
            Console.Write("Digite a porcetagem para aumentar o sálario: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
        }

        //Exibição da lista atualizada dos funcionários
        Console.WriteLine();
        Console.WriteLine("Lista atualizada dos funcionarios");
        foreach (Funcionarios obj in funcionarios)
        {
            Console.WriteLine(obj);
        }

        
        //Exercio 3º com matrizes

        //Entrada de dados para criar a matriz digitando o número de linhas e colunas
        string[] numeros = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(numeros[0]);
        int m = Convert.ToInt32(numeros[1]);

        //Criação da matriz
        int[,] mat = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                mat[i, j] = Convert.ToInt32(valores[j]);
            }
        }

        //Entrada do número a ser encontrado na matriz
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (mat[i, j] == x)
                {

                    //Imprime a posição do número na matriz
                    Console.WriteLine("Posição " + i + "," + j + ":");
                    if (j > 0)
                    {
                        Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                    }
                    if (i > 0)
                    {
                        Console.WriteLine($"Acima: {mat[i - 1, j]}");
                    }

                    if (j < n - 1)
                    {
                        Console.WriteLine($"Direita: {mat[i, j + 1]}");
                    }

                    if (i < m - 1)
                    {
                        Console.WriteLine($"Abaixo: {mat[i + 1, j]}");
                    }
                }
            }
        }
    }
}
