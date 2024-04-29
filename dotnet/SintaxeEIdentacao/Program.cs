using SintaxeEIdentacao.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade {listaString.Capacity}");

// Console.WriteLine("Percorrendo a Lista com o FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a Lista com o FOREACH");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }























// int[] arrayInteiros = new int [4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);





// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }


















// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForreach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForreach} - {valor}");
//     contadorForreach++;
// }












// Pessoa pessoa = new Pessoa();
// pessoa.Nome = "Manoel";
// pessoa.Idade = 19;
// pessoa.Apresentar();


























// string opcao;
// bool exibirMenu = true ;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digita a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar ");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
            
//          case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;

//          case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//          case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;
    
//     default:
//         Console.WriteLine("Opção Inválida");
//         break;
//     }
// };

// Console.WriteLine("sla");





















// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Soma dos Números (Digite 0 para Finalizar)");
//     Console.Write("Digite um número: ");
    

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


















// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//    Console.WriteLine($"{contador}º Execução {numero} x {contador} = {numero * contador}"); 
//    contador++;
//     if(contador == 6)
//     {
//         break;
//     }
   
// }























// int numero = 5;


// for (int contador = 0; contador <= 10; contador++)
// {
    
// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }





























//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);


// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero += 1;
// numeroIncremento++;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// //numero += 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);






















// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!")   ;
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }














// bool possuiPresencaMinima = true;
// double media = 6;
// //operador && verifica se as duas são verdadeiras
// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }




















// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)//operador ou/or "||"
// {
//    Console.WriteLine("Entrada liberada!") ;
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }
























// Console.WriteLine("Digite uma Letra: ");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }




















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
