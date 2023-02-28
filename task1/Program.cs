/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();
int[] array = GetRandomArray(10,100,999);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine ($"Колличество чётных чисел в массиве = {GetCountEven (array)}");

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }
    return result;
}

int GetCountEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] %2==0)
        {
            count++;
        }
    }
    return count;
}