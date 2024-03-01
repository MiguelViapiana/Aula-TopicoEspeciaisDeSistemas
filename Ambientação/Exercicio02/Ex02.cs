// See https://aka.ms/new-console-template for more information
using System;
 
namespace Exercicio02
{
    class Ex002
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----CONVERSOR DE MOEDAS----");
            double TaxaDolar = 5.17;
            double TaxaEuro = 6.14;
            double TaxaPesoArgentino = 0.05;

            Console.WriteLine("Digite um valor em Reais(R$): ");
            double valorReais = Convert.ToDouble(Console.ReadLine());

            double valorEuro = valorReais / TaxaEuro;
            double valorDolar = valorReais / TaxaDolar;
            double valorArgentino = valorReais / TaxaPesoArgentino;

            Console.WriteLine("O valor em dólar: "+ valorDolar.ToString("0,0"));
            Console.WriteLine("O valor em Euro: "+ valorEuro.ToString("0,0"));
            Console.WriteLine("O valor em Peso Argentino: "+ valorArgentino.ToString("00,0"));

            Console.ReadLine();
        }
    }
}
