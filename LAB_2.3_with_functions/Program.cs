//вариант 14 стр. 31-39
try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double Func_1(double x, double a, double b, double z)
    {
        double y;
        if (x <= 5 * a)
        {
            y = 2.5 * b * b + a * x - 4.5 * Math.Cos(x * z);
        }
        else if (x > b)
        {
            y = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z);
        }
        else
        {
            y = Math.Sqrt(6.5 * b * b + (a - Math.Pow(x, 3) * z));
        }
        return y;
    }
    Console.WriteLine($"y = {(Func_1(x, 0.5, 4.5, Math.Pow(Math.E, 0.5 * x))):F2}");
    Console.WriteLine($"y = {(Func_1(x, 0.5, 3.7, Math.Pow(Math.E, 2 * 0.5 * x))):F2}");
    Console.WriteLine($"y = {(Func_1(x, 0.5, 2.7, Math.Pow(Math.E, 2.5 * 0.5 * x))):F2}");
}

catch
{
    Console.WriteLine("введите данные правильно");
}