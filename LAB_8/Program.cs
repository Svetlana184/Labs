ProtectionTools[] tools = new ProtectionTools[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("введите инвентарный номер средства защиты");
    string? invNumber = Console.ReadLine();
    Console.WriteLine("введите название средства защиты");
    string? name = Console.ReadLine();
    Console.WriteLine("введите ФИО ответственного");
    string? fio = Console.ReadLine();
    Console.WriteLine("введите дату последней проверки");
    DateOnly dateOnly = DateOnly.Parse(Console.ReadLine()!);
    Console.WriteLine("введите очередность проверки в месяцах");

}








struct ProtectionTools
{
    public string InvNumber;
    public string Name;
    public string Fio;
    public DateOnly LastCheck;
    public TimeSpan timeSpan;
}