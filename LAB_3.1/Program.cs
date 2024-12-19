//вариант 6 стр.44-49
try
{
    int x = 1, sum = 0;
    while (x != 0)
    {
        Console.WriteLine("введите число");
        x = int.Parse(Console.ReadLine());
        if (x > 0)
        {
            sum += x;
        }
    }
    Console.WriteLine($"сумма положительных чисел последовательности равна {sum}");
}
catch
{
    Console.WriteLine("введите данные правильно");
}