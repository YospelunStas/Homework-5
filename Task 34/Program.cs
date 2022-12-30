// Задача 34: Задайте массив из 10 элементов, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    int currentNumber = int.Parse(array[i].ToString());
    int remain = currentNumber % 2;
    if (remain == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Колличество четных элементов массива - {count}");