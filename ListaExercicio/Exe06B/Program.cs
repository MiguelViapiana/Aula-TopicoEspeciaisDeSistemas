namespace Exe06B;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[] vetor = new int[100];
        //Criar o objeto que vai gerar o número randomico
        Random aleatorio = new Random();
        //Preencher vetor com valores
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(100);
        }
        Console.Write("Vetor Aleatorizado\n");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.Write("\n\nVetor Ordenado:\n");
        Array.Sort(vetor);
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }

}
