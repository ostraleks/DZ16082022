/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = A;
while (i > 0)
{
i = i / 10;
sum = sum + (A - i * 10);
A = i;   
}
Console.Write($"Сумма цифр в числе А = {sum}");
