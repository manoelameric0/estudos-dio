// using SintaxeEIdentaçao.Models;


Console.WriteLine("Digite uma Letra: ");
string letra = Console.ReadLine();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}




















// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal.");
// }














// if (letra == "a")
// {
//     Console.WriteLine("Volgal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal.");
// }












// int quantidadeEstoque = 4;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque : {quantidadeEstoque}");
// Console.WriteLine($"Quantidade compra : {quantidadeCompra}");
// Console.WriteLine($"É possivel realixar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. não temos a quantidade desejada em estoque.");
// }





// if (quantidadeCompra == 0)
// {
//     possivelVenda = false;
// }

// else if (quantidadeCompra <= quantidadeEstoque)
// {
//      possivelVenda = true;
// }
// else
// {
//     possivelVenda = false;
// }







// string a = "15-";

// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");





// double a = 4 / 2 + 2;

// Console.WriteLine(a);





// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);










// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


















//Cast - casting
//int a = Convert.ToInt32(null);
//int a = int.Parse(null);

//Console.WriteLine(a);












// int a = 10;
// int b = 20;

// int c = a + b;

// c *= 5;

// Console.WriteLine(c);




// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/M/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);



// double altura = 1.70;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da varável condição: " + condicao);




//Pessoa p = new Pessoa();

//p.Nome = "Manoel";
//p.Idade = 19;
//p.Apresentar();
