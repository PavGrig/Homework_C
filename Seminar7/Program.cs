// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
    return newArray;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {       
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}   

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandom2dArray(rows, columns));
*/
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,]CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i= 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();        
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
/*
void ShowValueOfArrayElement(int[,] array)
{
    Console.Write("Input a rows number of the required element: ");
    int rowsNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a columns number of the required element: ");
    int columnsNumber = Convert.ToInt32(Console.ReadLine());

    if(rowsNumber <= array.GetLength(0) && columnsNumber <= array.GetLength(1))
    Console.WriteLine("The value of the element with the specified indexes: " + array[rowsNumber, columnsNumber]);
    else Console.WriteLine("The array element with the specified index does not exist!!!");
}

ShowValueOfArrayElement(newArray);*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[] MeanArithmeticOf2dArrayColumnValues(int[,] array)
{
    double[] meanArithmeticColimns = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        meanArithmeticColimns[j] = Math.Round(sum / array.GetLength(0), 1);
    }
    return meanArithmeticColimns;
}

void ShowArray(double[] array)
{   
    Console.Write("The arithmetic mean of each column of the array: ");

    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

ShowArray(MeanArithmeticOf2dArrayColumnValues(newArray));*/