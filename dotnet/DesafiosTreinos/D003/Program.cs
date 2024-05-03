using D001.Models;

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();

Console.Write("Digite a letra que deseja contar: ");
char letra = Console.ReadKey().KeyChar;
Console.WriteLine();

contarLetras contaLetra = new contarLetras(frase, letra);
int contagem = contaLetra.ContadorDeLetras();

Console.WriteLine($"A Letra {letra} apareceu {contagem} vezes na frase.");

