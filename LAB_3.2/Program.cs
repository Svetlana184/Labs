//вариант 6 стр.40-43
try
{
    Console.WriteLine("введите число k:");
    int k = int.Parse(Console.ReadLine());
    double W = 0;
    for (int i = -2; i <= k; i++)
    {
        if (i != 4)
        {
            long factorial = 1;
            for (int j = 1; j <= i + 3; j++)
            {
                factorial *= j;
            }
            double temp = (Math.Pow(-1, i) * factorial) / (i - 4);
            W += temp;
        }
    }
    Console.WriteLine($"результат равен {W:F2}");
}
catch
{
    Console.WriteLine("введите число правильно!");
}