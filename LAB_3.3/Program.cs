try
{
    Console.WriteLine("введите x:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("введите n:");
    int n = int.Parse(Console.ReadLine());
    double s = 1;
    for (int i = 1; i <= n; i++)
    {
        long factorial = 1;
        for (int j = 1; j <= i; j++)
        {
            factorial *= j;
        }
        s += (Math.Cos((i * (Math.PI / 4)))) * Math.Pow(x, i) / factorial;
    }
    Console.WriteLine($"S = {s:F2}");
}
catch
{
    Console.WriteLine("введите число правильно!");
}