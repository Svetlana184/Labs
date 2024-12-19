//вариант 19 стр.16-24

try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine($"точка с координатами ({x}, {y}), попадает в заданную область - {(x * x + y * y <= 4) && (x * x + y * y >= 1)}");
}
catch
{
    Console.WriteLine("введите данные правильно");
}