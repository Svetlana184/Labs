//вариант 11 стр.74-81
Console.WriteLine("введите первое число");
string ch1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string ch2 = Console.ReadLine();


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
string tmp2 = new string('0', ch2.Length - 1);
string ed = tmp2 + "1";
string ch2_inv = "";
for (int i = 0; i < ch2.Length; i++)
{
    if (ch2[i] == '0') ch2_inv += "1";
    if (ch2[i] == '1') ch2_inv += "0";
}
Console.WriteLine("второе инвентированное число: " + ch2_inv);


string ch2_dop = Sum2(ch2_inv, ed);


string ch2_finally = "";

for (int i = ch2_dop.Length - 1; i >= 0; i--)
{
    ch2_finally += ch2_dop[i];
}
Console.WriteLine("второе число дополнительным кодом: " + ch2_finally);


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
            if (p == "0") return "1";
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