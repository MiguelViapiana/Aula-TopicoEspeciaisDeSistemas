
using System;
 
namespace Exercico01
{
    class Ex001
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a largura do retãngulo: ");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A área do retângulo é: "+ (altura*largura));
        }
    }
}
