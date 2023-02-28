/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
int minValue = -10;
int maxValue = 10;
int size = 4;
int[] array = GetRandomArray(size, minValue, maxValue);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {GetDifMaxMin(array)}");

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }
    return result;
}

int GetDifMaxMin (int [] array)
{
    int dif = 0;
    int max = minValue; 
    int min = maxValue;
    for (int i = 0; i<array.Length; i++)
    {
        if (max<array[i])
        {
            max=array[i];
        }
        if (min>array[i])
        {
            min=array[i];
        }
        dif=max-min;
        
    }
    return dif;
}