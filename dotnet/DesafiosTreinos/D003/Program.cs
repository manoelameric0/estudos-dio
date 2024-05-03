using D001.Models;
contarLetras contaLetra = new contarLetras();

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();

Console.Write("Digite a letra que deseja contar: ");
char letra = Console.ReadKey().KeyChar;

int contagem = contaLetra.contadorLetras(contaLetra.frase, contaLetra.letra);

Console.WriteLine($"\nA Letra {letra} apareceu {contagem} vezes na frase.");

