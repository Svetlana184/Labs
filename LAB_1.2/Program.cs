//вариант 16 стр.9-15

try
{
    Console.WriteLine("Введите длину стороны a");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину стороны b");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину стороны c");
    double c = double.Parse(Console.ReadLine());
    double medianaA = 0.5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
    double medianaB = 0.5 * Math.Sqrt(2 * a * a + 2 * c * c - b * b);
    double medianaC = 0.5 * Math.Sqrt(2 * b * b + 2 * a * a - c * c);
    Console.WriteLine($"медиана, проведённая к стороне a равна = {medianaA:F2}");
    Console.WriteLine($"медиана, проведённая к стороне b равна = {medianaB:F2}");
    Console.WriteLine($"медиана, проведённая к стороне c равна = {medianaC:F2}");

}
catch
{
    Console.WriteLine("Правильно введите данные");
}