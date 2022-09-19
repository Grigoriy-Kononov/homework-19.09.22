// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет


Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a<100)
{
Console.WriteLine($"У числа {a} нет третьей цифры");
}
else
{
string b = Convert.ToString(a);
Console.WriteLine($"Третья цифра - {b[2]}");
}


