//вариант 14 стр. 31-39
try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double y1, y2, y3, a = 0.5, b1 = 4.5, b2 = 3.7, b3 = 2.7;
    double z1 = Math.Pow(Math.E, a * x), z2 = Math.Pow(Math.E, 2 * a * x), z3 = Math.Pow(Math.E, 2.5 * a * x);
    if (x <= 5 * a)
    {
        y1 = 2.5 * b1 * b1 + a * x - 4.5 * Math.Cos(x * z1);
        y2 = 2.5 * b2 * b2 + a * x - 4.5 * Math.Cos(x * z2);
        y3 = 2.5 * b3 * b3 + a * x - 4.5 * Math.Cos(x * z3);
    }
    else if (x > b1)
    {
        y1 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z1);
        y2 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z2);
        y3 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z3);
    }
    else
    {
        y1 = Math.Sqrt(6.5 * b1 * b1 + (a - Math.Pow(x, 3) * z1));
        if (x > b2)
        {
            y2 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z2);
            y3 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z3);
        }
        else
        {
            y2 = Math.Sqrt(6.5 * b2 * b2 + (a - Math.Pow(x, 3) * z2));
            if (x > b3)
            {
                y3 = Math.Pow(a * a - 5.4 * x, 3) + Math.Log(x * z3);
            }
            else
            {
                y3 = Math.Sqrt(6.5 * b3 * b3 + (a - Math.Pow(x, 3) * z3));
            }
        }
    }
    Console.WriteLine($"y(x)={y1:F2}\ny(x)={y2:F2}\ny(x)={y3:F2}");
}

catch
{
    Console.WriteLine("введите данные правильно");
}