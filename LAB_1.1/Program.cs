try
{
    Console.WriteLine("Введите число m:");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число y:");
    double y = double.Parse(Console.ReadLine());
    double N = (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
    Console.WriteLine($"N = {N:F2}");
}
catch
{
    Console.WriteLine("Введите переменные правильно");
}