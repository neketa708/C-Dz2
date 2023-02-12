/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int z = 10;
int i = 0;
if (number>=100)
{
     while (number>100)
        {
                i = number % z;
                number /= 10;
                
        }
        Console.WriteLine(i);
} else
{
    Console.WriteLine("третьей цифры нет");
}