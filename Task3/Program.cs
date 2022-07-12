Console.Write("Введите число от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x <= 0 || x > 7)
{
    Console.WriteLine("Это число не подходит");
    x = Convert.ToInt32(Console.ReadLine());
}
if (x == 6 || x == 7)
    Console.WriteLine("Этот день является выходным");
else
    Console.WriteLine("Этот день не является выходным");
