Console.Write("Введите трехначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x <= 99 || x > 999)
{
    Console.WriteLine("Это число не подходит");
    x = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вторая цифра этого числа: ");
Console.Write(Convert.ToString(x)[1]);



// Альтернатива с рандомным числом
// int x = new Random().Next(100,1000);
// Console.WriteLine(x);
// Console.Write(Convert.ToString(x)[1]);
