// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Teste_Estatico_v1;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 1: Classe estática
        //Exemplo de uso da classe estática Calculadora
        Console.Write("Digite o valor do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculadora.Circunferencia(raio);
        double vol = Calculadora.Volume(raio);

        Console.WriteLine($"Circufêrencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        //Fim do exercício 1

        //Exercício 2: Conversão de moedas
        Console.Write("Qual é a cotação do dólar? ");
        double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valor = ConversorDeMoesdas.DolarParaReal(cotacao, quantia);

        Console.WriteLine($"Valor a ser pago em reais = {valor.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
