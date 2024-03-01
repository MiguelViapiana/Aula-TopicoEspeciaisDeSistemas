// See https://aka.ms/new-console-template for more information

using System;
 
namespace Exercicio04
{
    class Ex004
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if(idade <= 13){
                Console.WriteLine("Criança!");
            }else if(idade <= 18){
                Console.WriteLine("Adolescente!");
            }else if (idade <= 60){
                Console.WriteLine("Adulto!");
            }else{
                Console.WriteLine("Idoso!");
            }
        }
    }
}