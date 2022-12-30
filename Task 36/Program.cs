﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int sumOdd = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    double pos = i % 2;
    int currentNumber = int.Parse(array[i].ToString());
    if (pos != 0)
    {
        sumOdd = sumOdd + currentNumber;
    }
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOdd}");