// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
//и проверяет, является ли этот день выходным


Console.Clear();

Console.Write("Введите цифру дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a<1 || a>7)
{
              Console.WriteLine($"Нет такого дня недели");
}
else if (a>0 && a<6)
{
              Console.WriteLine($"Будний день");
}
else if (a == 6 ^ a == 7)
{
              Console.WriteLine($"Выходной день");
}

