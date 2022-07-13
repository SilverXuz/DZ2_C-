Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
    x = x * (-1);
else
    x = x * 1;
    
if (x >= 0 && x < 100)
    Console.Write("Третьего числа нет!");
else
    Console.Write(Convert.ToString(x)[2]);
