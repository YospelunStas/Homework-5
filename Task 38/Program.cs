// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int [10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}

int max = 0;
int min = 100;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}

int diff = max - min;

Console.WriteLine();
Console.WriteLine($"Максимальное значение массива = {max}");
Console.WriteLine($"Минимальное значение массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {diff}");