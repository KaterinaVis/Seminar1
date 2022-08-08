//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
if(number < 1000)
{
int lastDigit = number % 10;
Console.WriteLine(lastDigit);
}
}