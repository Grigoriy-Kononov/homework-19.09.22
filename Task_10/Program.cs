// Напишите программу, которая принимает на вход трехзначное число
// и на вывходе показывает вторую цифру этого числа


Console.Clear();

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a<100 || a>999)
{
Console.WriteLine($"Число {a} не является трехзначным");
}
else
{
string b = Convert.ToString(a);
Console.WriteLine($"Вторая цифра - {b[1]}");
}
