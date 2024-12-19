//вариант 11 стр.74-81

//ввод двух двоичных чисел
string ch1 = "";
string ch2 = "";
bool parametr = true;

while (parametr == true)
{
    Console.WriteLine("введите первое двоичное число");
    ch1 = Console.ReadLine();
    for (int i = 0; i < ch1.Length; i++)
    {
        if (ch1[i] == '0' || ch1[i] == '1')
        {
            if (i == ch1.Length - 1) parametr = false;
            continue;
        }
        else break;
    }
}
parametr = true;
while (parametr == true)
{
    Console.WriteLine("введите второе двоичное число");
    ch2 = Console.ReadLine();
    for (int i = 0; i < ch2.Length; i++)
    {
        if (ch2[i] == '0' || ch2[i] == '1')
        {
            if (i == ch2.Length - 1) parametr = false;
            continue;
        }
        else break;
    }
}


//делаем числа одинаковой длины
if (ch1.Length > ch2.Length)
{
    string tmp = new string('0', ch1.Length - ch2.Length);
    ch2 = tmp + ch2;
}
else
{
    string tmp = new string('0', ch2.Length - ch1.Length);
    ch1 = tmp + ch1;
}

//инвертируем второе число
string tmp2 = new string('0', ch2.Length - 1);
string ed = tmp2 + "1";
string ch2_inv = "";
for (int i = 0; i < ch2.Length; i++)
{
    if (ch2[i] == '0') ch2_inv += "1";
    if (ch2[i] == '1') ch2_inv += "0";
}
Console.WriteLine("второе инвентированное число: " + ch2_inv);

//дополнительный код второго числа
string ch2_dop = Sum2(ch2_inv, ed);


string ch2_finally = "";

for (int i = ch2_dop.Length - 1; i >= 0; i--)
{
    ch2_finally += ch2_dop[i];
}
Console.WriteLine("второе число дополнительным кодом: " + ch2_finally);


//опять делаем числа одинаковыми
if (ch1.Length > ch2_finally.Length)
{
    string tmp = new string('0', ch1.Length - ch2_finally.Length);
    ch2_finally = tmp + ch2_finally;
}
else
{
    string tmp = new string('0', ch2_finally.Length - ch1.Length);
    ch1 = tmp + ch1;
}


string sum = Sum2(ch1, ch2_finally);
string rez = "";
for (int i = sum.Length - 1; i >= 0; i--)
{
    rez += sum[i];
}
Console.WriteLine(rez);
rez = rez.Substring(1, rez.Length - 1);
Console.WriteLine($"{ch1} - {ch2} = {rez}");



string Sum2(string ch1, string ch2, string p = "0")
{
    if (ch1.Length > 1)
    {
        if (ch1[ch1.Length - 1] != ch2[ch2.Length - 1])
        {
            ch1 = ch1.Substring(0, ch1.Length - 1);
            ch2 = ch2.Substring(0, ch2.Length - 1);
            if (p == "0") return 1 + Sum2(ch1, ch2);
            else return 0 + Sum2(ch1, ch2, p = "1");


        }
        else if (ch1[ch1.Length - 1] == '1' && ch2[ch2.Length - 1] == '1')
        {
            ch1 = ch1.Substring(0, ch1.Length - 1);
            ch2 = ch2.Substring(0, ch2.Length - 1);
            if (p == "0") return 0 + Sum2(ch1, ch2, p = "1");
            else return 1 + Sum2(ch1, ch2, p = "1");

        }
        else
        {
            ch1 = ch1.Substring(0, ch1.Length - 1);
            ch2 = ch2.Substring(0, ch2.Length - 1);
            if (p == "0") return 0 + Sum2(ch1, ch2);
            else return 1 + Sum2(ch1, ch2, p = "0");
        }

    }
    else
    {
        if (ch1[ch1.Length - 1] != ch2[ch2.Length - 1])
        {
            if (p == "0") return "10";
            else return "11";

        }
        else if (ch1[ch1.Length - 1] == '1' && ch2[ch2.Length - 1] == '1')
        {
            if (p == "0") return "01";
            else return "11";
        }
        else
        {
            if (p == "1") return p;
            else return "";
        }
    }
}