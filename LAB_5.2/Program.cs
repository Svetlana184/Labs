Console.WriteLine("введите строку");
string str = Console.ReadLine();
string strRez = "";
while (str.Length > 0)
{
    int firstSpace = str.IndexOf(' ');
    if (firstSpace != -1)
    {
        strRez += str.Substring(0, firstSpace);
        int countSpace = 0;
        for (int i = firstSpace; i < str.Length; i++)
        {
            if (str[i] == ' ') countSpace++;
            else break;
        }
        if (countSpace % 2 == 0)
        {
            string temp = new string('Ч', countSpace);
            strRez += temp;
        }
        else if (countSpace % 2 == 1)
        {
            string temp = new string('Н', countSpace);
            strRez += temp;
        }
        str = str.Substring(firstSpace + countSpace);
    }
    else
    {
        strRez += str;
        break;
    }
}
Console.WriteLine(strRez);
