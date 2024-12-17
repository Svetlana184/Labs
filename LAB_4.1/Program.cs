double[] mas = new double[12];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    int temp = random.Next(10, 100);
    int counter = 0;
    mas[i] = 0;
    while (temp > 1)
    {
        mas[i] = mas[i] + (temp % 2) * Math.Pow(10, counter);
        counter += 1;
        temp /= 2;
    }
    mas[i] += 1 * Math.Pow(10, counter);

}
Console.WriteLine("необработанный массив:");
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    double ex = mas[i];
    int counter2 = 0;
    for (int j = i; j < mas.Length; j++)
    {
        if (ex == mas[j])
        {
            counter2++;
            if (counter2 > 2)
            {
                mas[j] = 0;
            }
        }
    }
}
double[] res = Array.FindAll(mas, p => p != 0);
Console.WriteLine("обработанный массив:");
foreach (int item in res) Console.Write(item + " ");
Console.WriteLine();
