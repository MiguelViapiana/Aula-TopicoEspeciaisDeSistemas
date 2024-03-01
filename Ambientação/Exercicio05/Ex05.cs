// See https://aka.ms/new-console-template for more information

using System;
 
namespace Exercicio05
{
    class Ex005
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----SEQUÊNCIA DE FIBONACCI----");
            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i =0;
            int p =1;
            int temp;

            Console.WriteLine(i );
            Console.WriteLine(p );
            while((temp = i + p) <= num){
                Console.WriteLine(temp);
                i = p;
                p = temp;
                
            }

            
        }
    }
}
