//Exercico 0: Ler a idade como um valor inteiro
Console.WriteLine("Digite a sua diade: ");
string idade = Console.ReadLine();
int i = Convert.ToInt64(idade);
Console.WriteLine("Idade é de: " + idade);
if(i > 18){
    Console.WriteLine("Você é uma criança :D");
}else if (i > 60){
    Console.WriteLine("Você é um adulto :)");
}else{
    Console.WriteLine("Você é um idoso XD");
}