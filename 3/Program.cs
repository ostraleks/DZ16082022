﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int [] AnyArray(int size)
{
    int[] resarr = new int[size];
    for (int i = 0; i < resarr.Length; i++)
    {
        resarr[i] = new Random().Next(1, 100);
    }
    return resarr;
}
int [] finarray = AnyArray(8);
Console.WriteLine($"Результат: [ {String.Join(", ", finarray)} ]");
