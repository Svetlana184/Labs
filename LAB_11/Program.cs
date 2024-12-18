using LAB_11;


Console.WriteLine("введите название антенны");
string? name = Console.ReadLine();
Console.WriteLine("введите мощность антенны");
double power = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите длину антенны");
double height = double.Parse(Console.ReadLine()!);
Antenn antenn = new Antenn(name!, power, height);

Console.WriteLine(antenn);

Console.WriteLine("введите коэффициент излучения");
double emissivity = double.Parse(Console.ReadLine()!);
AntennSuper antenn1 = new AntennSuper(name!, power, height, emissivity);

Console.WriteLine(antenn1);