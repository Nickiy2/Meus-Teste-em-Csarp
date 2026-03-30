using System;
using System.Drawing;
using System.Globalization;
using Teste_Estatico_v1._0;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 1: Classe estática
        //Exemplo de uso da classe estática Calculadora
        Console.Write("Digite o valor do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circunferencia = Calculadora.Circuferencia(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine($"Circufêrencia: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        
        //Fim do Exercício 1
        
        //Exercício 2: Conversão de moedas
        Console.Write("Qual é a cotação do dólar? ");
        double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valorPago = ConversorDeMoesdas.ConverterDolarParaReal(cotacao, quantia);

        Console.WriteLine($"Valor a ser pago em reais = {valorPago.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}