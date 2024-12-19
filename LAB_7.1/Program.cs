//вариант 13 стр. 117-124
Car[] cars = new Car[3];
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine("введите марку машины");
    string name = Console.ReadLine();
    Console.WriteLine("Введите производителя");
    string manufacturer = Console.ReadLine();
    Console.WriteLine("выберите грузоподъемность");
    int capacity = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите год выпуска");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("введите дату регистрации");
    DateTime registrationDate = DateTime.Parse(Console.ReadLine());
    Car car = new Car(name, manufacturer, capacity, year, registrationDate);
    cars[i] = car;
}

foreach (Car car in cars)
{
    if (DateTime.Now.Subtract(car.Registration).TotalDays > 365 && car.Capacity > 3) car.Print();
}

struct Car
{
    public string Brand;
    public string Manufacturer;
    public double Capacity;
    public int Date;
    public DateTime Registration;
    public Car(string brand, string manufacturer, double capacity, int date, DateTime registration)
    {
        Brand = brand;
        Manufacturer = manufacturer;
        Capacity = capacity;
        Date = date;
        Registration = registration;
    }
    public void Print()
    {
        Console.WriteLine($"Марка автомобиля: {Brand}\nПроизводитель: {Manufacturer}\nГрузоподъемность: {Capacity}\nГод выпуска: {Date}\nДата регистрации: {Registration}\n");
    }
}