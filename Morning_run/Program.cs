Console.Write("Сколько КМ в первый день? Введите число от 0 до 1000: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько КМ в день для поставленной цели? Введите число больше, чем первый день: ");
int y = Convert.ToInt32(Console.ReadLine());
while (y <= x)
{
    Console.WriteLine("Это число не подходит");
    y = Convert.ToInt32(Console.ReadLine());
}
int day = 0;
while (x < y)
{
    x = (x * 0.15 + x);
    day++;
}
Console.Write(day + " дней");