/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();
int[] array = GetRandomArray(4,-10,10);
Console.Write($"[{String.Join(",", array)}]");
Console.Write($" => Сумма элементов стоящих на нечётных позициях = {GetSumElements(array)}");

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }
    return result;
}

int GetSumElements (int [] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}