Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|         x         |        f(x)       |");
Console.WriteLine("|---------------------------------------|");
for (double x = -3; x <= 2.5; x += 1.1)
{
    double y = 0;
    if (x > 0)
    {

        for (int k = 1; k <= 8; k++)
        {
            long factorial = 1;
            for (int j = 1; j <= k; j++) factorial *= j;
            y += Math.Pow(-1, k) * Math.Pow(x, k) / factorial;
        }
    }
    else y = Math.Tan(Math.Pow(Math.PI, x));
    Console.WriteLine($"|       {x,5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
