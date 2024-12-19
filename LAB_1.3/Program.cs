//вариант 3.26 сборник задач. Златопольский
try
{
    Console.WriteLine("введите трёхзначное число");
    int a = int.Parse(Console.ReadLine());
    int sot = a / 100;
    int dec = a % 100 / 10;
    int ed = a % 10;
    Console.WriteLine($"числа, образованные с помощью перестановки цифр:\n{ed * 100 + dec * 10 + sot}\n{ed * 100 + sot * 10 + dec}\n{dec * 100 + sot * 10 + ed}\n{dec * 100 + ed * 10 + sot}\n{sot * 100 + ed * 10 + dec}\n{a}");
}
catch
{
    Console.WriteLine("введите данные правильно");
}