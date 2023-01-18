// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)

{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(100, 1000);
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}
Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]array = CreateRandomArray(size);
ShowArray(array);

int NumOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.WriteLine("There are " + NumOfEvenNumbers(array) + " even numbers in the array");*/

//Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minvalue, int maxvalue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minvalue, maxvalue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int SumAllOddArrayPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.WriteLine("The sum of the numbers of each odd position of the array = " + SumAllOddArrayPosition(array));*/

//Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minvalue, int maxvalue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    
        array[i] = Math.Round(new Random().Next(minvalue, maxvalue + 1) + new Random().NextDouble(), 2);
    
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size, min, max);
ShowArray(array);

double DiffMaxMinElemArray(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
        result = max - min;
    Console.WriteLine("Max element array = " + max);
    Console.WriteLine("Min element array = " + min);
    return result;
}

Console.WriteLine("The difference between the maximum and minimum array element = " + DiffMaxMinElemArray(array));