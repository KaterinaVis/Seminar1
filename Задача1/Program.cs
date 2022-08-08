/*Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.*/
Console.WriteLine("Ввдите первое число ");
string input = Console.ReadLine();
int numberA = Convert.ToInt32(input);
Console.WriteLine("Ввдите второе число ");
input = Console.ReadLine();
int numberВ = Convert.ToInt32(input);
if(numberВ == numberA * numberA)
{
   Console.WriteLine(numberВ + " квадрат " + numberA); 
}
else
{
     Console.WriteLine(numberВ + " не является квадратом " + numberA);
}