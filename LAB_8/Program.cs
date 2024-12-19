//вариант 19 стр.155-172
ProtectionTools[] tools = new ProtectionTools[2];
for (int i = 0; i < tools.Length; i++)
{
    try
    {
        Console.WriteLine("вводим данные средства защиты №" + (i+1)) ;
        Console.WriteLine("введите инвентарный номер средства защиты");
        string? invNumber = Console.ReadLine();
        Console.WriteLine("введите название средства защиты");
        string? name = Console.ReadLine();
        Console.WriteLine("введите ФИО ответственного");
        string? fio = Console.ReadLine();
        Console.WriteLine("введите дату последней проверки");
        DateOnly lastCheck = DateOnly.Parse(Console.ReadLine()!);
        Console.WriteLine("введите очередность проверки в месяцах");
        int months = int.Parse(Console.ReadLine()!);
        ProtectionTools tool = new ProtectionTools();
        tool.InvNumber = invNumber!;
        tool.Name = name!;
        tool.Fio = fio!;
        tool.LastCheck = lastCheck;
        tool.Queue = months;
        tools[i] = tool;
    }
    catch
    {
        Console.WriteLine("введите данные правильно!");
        i--;
    }
}
Console.WriteLine();
Console.WriteLine("СВЕДЕНИЯ О ВСЕХ ЗАЩИТНЫХ СРЕДСТВАХ\n\n");
foreach (ProtectionTools tool in tools)
{
    tool.Print();
    Console.WriteLine("Дата следующей проверки: " + tool.LastCheck.AddMonths(tool.Queue));
    Console.WriteLine();
}

Console.WriteLine("СВЕДЕНИЯ О СРЕДСТВАХ, ПРОВЕРКА КОТОРЫХ ЗАПЛАНИРОВАНА НА СЛЕДУЮЩИЙ МЕСЯЦ:\n\n");
foreach (ProtectionTools tool in tools)
{
    if ((tool.LastCheck.AddMonths(tool.Queue)).Month == DateOnly.FromDateTime(DateTime.Now).AddMonths(1).Month)
    {
        tool.Print();
        Console.WriteLine();
    }
}







struct ProtectionTools
{
    public string InvNumber;
    public string Name;
    public string Fio;
    public DateOnly LastCheck;
    public int Queue;

    public ProtectionTools(string invNumber, string name, string fio, DateOnly lastCheck, int queue)
    {
        InvNumber = invNumber;
        Name = name;
        Fio = fio;
        LastCheck = lastCheck;
        Queue = queue;
    }

    public void Print()
    {
        Console.WriteLine($"инвентарный номер: {InvNumber}\nнаименование: {Name}\nФИО ответственного: {Fio}\nдата последней проверки: {LastCheck}\nочередность проверки в месяцах: {Queue}");
    }
}