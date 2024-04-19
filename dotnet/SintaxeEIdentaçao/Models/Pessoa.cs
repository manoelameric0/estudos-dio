namespace SintaxeEIdentação;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentaçao()
    {
        Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos");
    }
}
