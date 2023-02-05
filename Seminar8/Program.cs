// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    for(int j = 0; j < array.GetLength(1); j++)
       Console.Write(array[i, j] + "\t");
    Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[,] SortingArrayReduceValueOfRowElements(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
      
         for(int j = 0; j < array.GetLength(1); j++)

            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i , k + 1] > array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                } 


            }   
    return array;
}

int[,] sortArray = SortingArrayReduceValueOfRowElements(newArray);
Show2dArray(sortArray);
*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[] SumElementsRows2dArray(int[,] array)
{
    int[] sumElements = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumElements[i] = sum;
        }
    }
    return sumElements;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] sumArray = SumElementsRows2dArray(newArray);
ShowArray(sumArray);

int IndexMinSumElements(int[] array)
{
    int minSum = array[0];
    int index = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minSum)
        {
            minSum = array[i];
            index = i;
        }
        
    }
    return index;
}

Console.WriteLine("The number of the row with the smallest sum of elements: " + (IndexMinSumElements(sumArray) + 1));*/


// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MultipliedTwo2dArrays(int[,] array1, int[,] array2)
{
        int[,] multipliedArray = new int[array1.GetLength(0), array2.GetLength(1)];
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                int temp = 0;
                for(int k = 0; k < array1.GetLength(1); k++)
                {
                    temp += array1[i, k] * array2[k, j];
                }
                multipliedArray[i, j] = temp;
            }
        }
        return multipliedArray;
}

int[,] newArray2 = CreateRandom2dArray();
Show2dArray(newArray);
Show2dArray(newArray2);

if(newArray.GetLength(1) != newArray2.GetLength(0))
Console.Write("The arrays entered are incompatible and cannot be multiplied!!!");
else
{
int[,] multipliedArray = MultipliedTwo2dArrays(newArray, newArray2);
Show2dArray(multipliedArray);
}*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int plane, int rows, int columns, int sizeArray)
{
    int[] array = new int[sizeArray];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(10, 100);
            
            for (int j = 0; j < i; j++)
            {
                if(array[j] == array[i])
                i--;
            }
        }
    
    int[,,] array3D = new int[plane, rows, columns];
    int m = 0;
        for(int k = 0; k < array3D.GetLength(0); k++)
            for (int i = 0; i < array3D.GetLength(1); i++)
                for(int j = 0; j < array3D.GetLength(2); j++)
                {
                    array3D[k, i, j] = array[m];
                    m++;
                }           
       
        return array3D;         
}


void Show3dArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
              
            for(int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < array.GetLength(2); j++)
                Console.Write(array[k, i, j] + "(" + k + "," + i + "," + j + ")" + "\t");
            }
            
    Console.WriteLine();
}

Console.Write("Input a number of rows array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns array: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of plane array: ");
int plane = Convert.ToInt32(Console.ReadLine());
int sizeArray = rows * columns * plane;

if(sizeArray <= 90)
{
int[,,] newArray = CreateRandom3dArray(plane, rows, columns, sizeArray);
Show3dArray(newArray);
}

else Console.WriteLine("The size of the array exceeds the maximum possible value of the array element!!!!!!");

*/

//Задача 5. Напишите программу, которая заполнит спирально массив двумерный массив.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int sizeArray = rows * columns;
    int[,] array = new int[rows, columns];

    int num = 1;
    int fillingCircle = 0;
    int direction = 1;
    while(num <= sizeArray)
    {
        if(direction == 1)
        {
            for(int j = fillingCircle; j < array.GetLength(1) - fillingCircle; j++)
            {
                if(num <= sizeArray)
                {
                    array[fillingCircle, j] = num;
                    num++;
                }
            }
            direction = 2;
        }

        if(direction == 2)
        {
            for(int i = 1 + fillingCircle; i < array.GetLength(0) - fillingCircle; i++)
            {
                if(num <= sizeArray)
                {
                    array[i, columns - 1 - fillingCircle] = num;
                    num++;
                }
            }
            direction = 3;
        }
        
        if(direction == 3)
        {
            for(int j = columns - 2 - fillingCircle; j >= fillingCircle; j--)
            {
                if(num <= sizeArray)
                {
                    array[rows - 1 - fillingCircle, j] = num;
                    num++;
                }
            }
            direction = 4;
        }

        if(direction == 4)
        {
            for(int i = rows - 2 - fillingCircle; i > 0 + fillingCircle; i--)
            {
                if(num <= sizeArray)
                {
                    array[i, fillingCircle] = num;
                    num++;
                }
            }
            direction = 1;    
        }
        fillingCircle++;
    }
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    for(int j = 0; j < array.GetLength(1); j++)
       Console.Write(array[i, j] + "\t");
    Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/