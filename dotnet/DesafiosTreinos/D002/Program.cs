string l1s,l2s,l3s;
int l1,l2,l3;
bool eq,es,tri;

Console.Write("Digite o primeiro lado: ");
l1s = Console.ReadLine();
int.TryParse(l1s, out l1);
Console.Write("Digite o segundo lado: ");
l2s = Console.ReadLine();
int.TryParse(l2s, out l2);
Console.Write("Digite o terceiro lado: ");
l3s = Console.ReadLine();
int.TryParse(l3s, out l3);
tri = (l1 < l2 + l3) && (l2 < l1 + l3) && (l3 < l1 + l2);
eq = (l1 == l2) && (l2 == l3);
es = (l1 != l2) && (l2 != l3) && (l1 != l3);

Console.WriteLine($"Pode formar um TRIANGULO? {tri}");
Console.WriteLine($"Pode formar um EQUILATERO? {eq}");
Console.WriteLine($"Pode formar um ESCALENO? {es}");



