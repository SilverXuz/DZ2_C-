Console.Write("Введите сумму вклада от 1 до 1000: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x <= 0 || x > 1000)
{
    Console.WriteLine("Это число не подходит");
    x = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите сумму, которую планируете накопить: ");
int y = Convert.ToInt32(Console.ReadLine());
while (y <= x)
{
    Console.WriteLine("Итоговая сумма не может быть меньше вклада");
    y = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите процентную ставку от 1 до 100 %: ");
int p = Convert.ToInt32(Console.ReadLine());
while (p <= 0 || p > 100)
{
    Console.WriteLine("Это число не подходит");
    p = Convert.ToInt32(Console.ReadLine());
}
int year = 0;
while (x < y)
{
    x = (x * p / 100 + x);
    year++;
}
Console.Write(year + " лет");
