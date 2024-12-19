using static ClassLibr_6_2.Class6_2;

//вариант 23 стр.81-86
double[,] masMain = new double[3, 3];
for (int i = 0; i < masMain.GetLength(0); i++)
{
    for (int j = 0; j < masMain.GetLength(1); j++)
    {
        masMain[i, j] = Math.Pow(Math.Log(2 * (i + 1) + 8 * (j + 1)), 8) - Math.Pow(Math.E, Math.E);
        Console.Write($"{masMain[i, j]:F2} ");
    }
    Console.WriteLine();
}
double[] vector = MinSt(masMain);
Console.WriteLine("\nстолбец с минимальной суммой модулей элементов: ");
foreach (double v in vector) Console.WriteLine($"{v:F2} ");
double rez = Rez(vector);
Console.WriteLine($"\nпроизведение элементов столбца с чётными индексами: {rez:F2}");