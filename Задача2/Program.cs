Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1)
{
Console.WriteLine("Понедельник");
}
else if (numberA == 2)
{
Console.WriteLine("Вторник");
}
else if (numberA == 3)
{
Console.WriteLine("Среда");
}
else if (numberA == 4)
{
Console.WriteLine("Четверг");
}
else if (numberA == 5)
{
Console.WriteLine("Пятница");
}
else if (numberA == 6)
{
Console.WriteLine("Суббота");
}
else if (numberA == 7)
{
Console.WriteLine("Воскресенье");
}
else
{
Console.WriteLine("Нет такого дня недели");
}