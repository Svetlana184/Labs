int[,] mas = new int[3, 3];
Random random = new Random();
int min_sum = int.MaxValue;
Console.WriteLine("исходный массив:");
for (int i = 0; i < mas.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(0, 20);
        Console.Write(mas[i, j] + " ");
        sum += mas[i, j];
    }
    Console.WriteLine();
    if (sum < min_sum) min_sum = sum;
}
Console.WriteLine($"минимальная сумма элементов строки - {min_sum}");
Console.WriteLine("изменённый массив:");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] *= min_sum;
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}