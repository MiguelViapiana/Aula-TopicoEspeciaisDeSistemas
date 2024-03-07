//Criar um vetor
int[] vetor = new int[100];
//Criar o objeto que vai gerar o número randomico
Random aleatorio = new Random();
//Preencher vetor com valores
for (int i = 0; i < vetor.Length; i++){
    vetor[i] = aleatorio.Next(1000);
}
Console.Write("Array Aleatórizado \n");
for (int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
Console.Write("\n\n");
Console.Write("Array Ordenado \n");
Boolean troca = true;
do{
    troca = false;
    for(int i = 0; i < vetor.Length-1; i++){
        if(vetor[i] > vetor[i+1]){
            int aux = vetor[i];
            vetor[i] = vetor[i+1];
            vetor[i + 1] = aux;
            troca = true;
        }
    }
}while(troca == true);

for (int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
//Visualgo, toptal