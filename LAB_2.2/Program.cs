//вариант 9 стр. 25-31
try
{
    Console.WriteLine("Введите трёхзначное число:");
    int x = int.Parse(Console.ReadLine());
    if (x / 1000 == 0 && x / 100 != 0)
    {
        int sumNum = x / 100 + x % 10 + x % 100 / 10;
        int sumProizv = (x / 100) * (x % 10) * (x % 100 / 10);
        if (sumNum / 100 == 0 && sumNum / 10 != 0)
        {
            Console.WriteLine("сумма цифр числа - двузначное число");
        }
        else { Console.WriteLine("сумма цифр числа - не двузначное число"); }

        if (sumProizv / 1000 == 0 && sumProizv / 100 != 0)
        {
            Console.WriteLine("произведение цифр числа - трёхзначное число");
        }
        else { Console.WriteLine("произведение цифр числа - не трёхзначное число"); }
    }
    else { Console.WriteLine("введите трёхзначное число!"); }


}

catch
{
    Console.WriteLine("введите данные правильно");
}
