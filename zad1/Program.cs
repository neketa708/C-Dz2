/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number<100)
{
    Console.WriteLine("число не трехзначное");
} else if (number>999)
{
    Console.WriteLine("число не трехзначное");
} else
{
int secondNumber = number/10%10;
Console.WriteLine(secondNumber);
}