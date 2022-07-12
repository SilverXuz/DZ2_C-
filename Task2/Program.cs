Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100)
    Console.Write("Третьего числа нет!");
else
    Console.Write(Convert.ToString(x)[2]);
