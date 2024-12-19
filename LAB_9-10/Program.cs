using LAB_9_10;

//вариант 24 стр.186-191
try
{
    Console.WriteLine("введите x");
    double x = double.Parse(Console.ReadLine()!);
    Console.WriteLine("введите y");
    double y = double.Parse(Console.ReadLine()!);
    Console.WriteLine("введите z");
    double z = double.Parse(Console.ReadLine()!);
    Chiselki chiselki = new Chiselki(x, y, z);
    chiselki.Print();
    Console.WriteLine($"среднее геометрическое чисел: {chiselki.SrGeom():F2}");
    Console.WriteLine($"количество цифр в сумме заданных трёх чисел: {chiselki.NumSum()}");

    Console.WriteLine("введите a");
    double a = double.Parse(Console.ReadLine()!);
    Console.WriteLine("введите b");
    double b = double.Parse(Console.ReadLine()!);
    Console.WriteLine("введите c");
    double c = double.Parse(Console.ReadLine()!);
    Chiselki_six chiselki1 = new Chiselki_six(x, y, z, a, b, c);
    Console.WriteLine($"скалярное произведение наборов чисел x,y,z и a,b,c: {chiselki1.ScalyarProizv()}");

}
catch
{
    Console.WriteLine("введите данные правильно!");
}
