// See https://aka.ms/new-console-template for more information

using System;
 
namespace Exercicio03
{
    class Ex003
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois nùmeros: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int maior_num = num1;
            int menor_num = num2;
            if(num1 < num2){
                maior_num = num2;
                menor_num = num1;
            }
            Console.WriteLine("O maior número é o: "+ maior_num);
            Console.WriteLine("O menor número é o: "+ menor_num);
        }
    }
}
